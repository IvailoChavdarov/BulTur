using BulTur.Server.Data;
using BulTur.Server.Dto;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulTur.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffAccountsController : ControllerBase
    {
        private readonly UserManager<StaffAccount> _userManager;
        private readonly SignInManager<StaffAccount> _signInManager;

        public StaffAccountsController(UserManager<StaffAccount> userManager, SignInManager<StaffAccount> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //returns user data to be displayed in the account page
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<StaffAccount>> Get() {
            StaffAccount? currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return NotFound();

            return Ok(currentUser);
        }

        //returns data for all users (for admin)
        [Authorize(Roles = "Admin")]
        [HttpGet("GetAllUsers", Name = "GetAllUsers")]
        public async Task<ActionResult<List<StaffAccount>>> GetAll()
        {
            List<StaffAccount> users = await _userManager.Users.ToListAsync();
            return Ok(users);
        }

        //registers user (by admin)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AccountCreateDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new StaffAccount
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            var userId = await _userManager.GetUserIdAsync(user);
            await _userManager.AddToRoleAsync(user, model.RoleName);

            return Ok();
        }

        //creates the first account in the system with role of Admin
        [HttpPost("CreateAdminAccount", Name = "CreateAdminAccount")]
        public async Task<ActionResult> CreateAdminAccount([FromBody] AccountCreateDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var admins = await _userManager.GetUsersInRoleAsync("Admin");
            if (admins.Count == 0)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = new StaffAccount
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (!result.Succeeded)
                    return BadRequest(result.Errors);


                var userId = await _userManager.GetUserIdAsync(user);
                await _userManager.AddToRoleAsync(user, "Admin");

                return Ok();
            }
            else
            {
                return BadRequest("Admin already exists");
            }
        }

        //Signs user in
        [HttpPost("Login", Name = "Login")]
        public async Task<ActionResult> Login([FromBody] LoginDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var signInResult = await _signInManager.PasswordSignInAsync(dto.Email, dto.Password, true, false);

            if (signInResult.Succeeded)
                return Ok();

            return BadRequest();
        }

        //Signs current user out
        [HttpPost("LogOut", Name = "LogOut")]
        [Authorize]
        public async Task<ActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Ok("Signed out successfully!");
        }

        //Deletes user from the database
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(string id)
        {
            StaffAccount? userToDelete = await _userManager.FindByIdAsync(id);
            if (userToDelete == null)
                return NotFound();

            if (userToDelete.Id == _userManager.GetUserId(User))
                return BadRequest("You cannot delete your own account.");

            var deleteResult = await _userManager.DeleteAsync(userToDelete);
            if (!deleteResult.Succeeded)
                return BadRequest(deleteResult.Errors);

            return Ok("User successfully deleted!");
        }

        //Changes users password if he forgot it (by admin)
        [HttpPatch("ResetPassword", Name = "ResetPassword")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ResetPassword([FromBody] ResetPasswordDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            StaffAccount? user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                return NotFound();

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetResult = await _userManager.ResetPasswordAsync(user, token, dto.NewPassword);

            if (!resetResult.Succeeded)
                return BadRequest(resetResult.Errors);

            return Ok("Password reset successfully.");
        }

        [Authorize]
        [HttpPatch("ChangePassword", Name = "ChangePassword")]
        public async Task<ActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            StaffAccount? user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound();
            var changeResult = await _userManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);

            if (!changeResult.Succeeded)
                return BadRequest(changeResult.Errors);

            return Ok("Password changed successfully.");
        }

        //Changes given user's role
        [Authorize(Roles = "Admin")]
        [HttpPost("ChangeRole", Name = "ChangeRole")]
        public async Task<ActionResult> ChangeRole([FromBody] ChangeRoleDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            StaffAccount? userToChange = await _userManager.FindByEmailAsync(dto.UserEmail);
            if (userToChange == null)
                return NotFound();
            if (dto.RoleName == "Admin")
            {
                var admins = await _userManager.GetUsersInRoleAsync("Admin");
                StaffAccount? currentAdmin = admins.FirstOrDefault();
                if (currentAdmin == null)
                    return BadRequest();
                await _userManager.RemoveFromRoleAsync(currentAdmin, "Admin");
            }

            await _userManager.RemoveFromRolesAsync(userToChange, await _userManager.GetRolesAsync(userToChange));

            var addResult = await _userManager.AddToRoleAsync(userToChange, dto.RoleName);

            if (!addResult.Succeeded)
                return BadRequest(addResult.Errors);

            return Ok();
        }
    }
}
