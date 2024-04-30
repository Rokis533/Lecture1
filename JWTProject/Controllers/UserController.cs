﻿using JWTProject.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;
using JWTProject.Helper;

namespace JWTProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserContext _userContext;
        private readonly IJWTService _jwtService;

        public UserController(UserContext userContext, IJWTService jwtService)
        {
            _userContext = userContext;
            _jwtService = jwtService;
        }
        [AllowAnonymous]
        [HttpPost("SignUp")]
        public User SignUp(string username, string password)
        {
            var user = UserHelper.CreateUser(username, password);
            _userContext.Add(user);
            _userContext.SaveChanges();
            return user;
        }
        [AllowAnonymous]
        [HttpGet("LogIn")]
        public ActionResult LogIn(string username, string password)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);

            if (UserHelper.VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
            {
                var role = user.Role;
                return Ok(_jwtService.GetJWT(username, role));
            }

            return Unauthorized();
        }

        [HttpGet("ChangeUsername")]
        [Authorize]
        public ActionResult ChangePasswordFromJwt(string newUsername)
        {
            //var name2 = User.FindFirstValue(ClaimTypes.Name);

            var identity = Request.HttpContext.User.Identity;
            if (identity is null)
            {
                return BadRequest("no username");
            }

            var name = identity.Name;

            var user = _userContext.Users.FirstOrDefault(x => x.Username == name);

            user.Username = newUsername;
            _userContext.SaveChanges();

            return Ok("Username changed succesfully");

        }
        [HttpGet("ChangePasswordFromJwt")]
        [Authorize]
        public ActionResult ChangePasswordFromJwt(string newPassword, string repeatNewPassword)
        {

            var identity = Request.HttpContext.User.Identity;
            if (identity is null)
            {
                return BadRequest("no username");
            }

            var name = identity.Name;

            var user = _userContext.Users.FirstOrDefault(x => x.Username == name);

            if (newPassword == repeatNewPassword)
            {
                UserHelper.CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                _userContext.SaveChanges();

                return Ok("Password changed succesfully");

            }

            return BadRequest("Passwords are different");
        }
        [HttpGet("ChangePassword")]
        [Authorize]
        public ActionResult ChangePassword(string username, string oldPassword, string newPassword, string repeatNewPassword)
        {

            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);
            if (UserHelper.VerifyPassword(oldPassword, user.PasswordHash, user.PasswordSalt))
            {
                if (newPassword == repeatNewPassword)
                {
                    UserHelper.CreatePasswordHash(newPassword, out byte[] passwordHash, out byte[] passwordSalt);
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    _userContext.SaveChanges();
                    return Ok("Password changed succesfully");
                }
                return BadRequest("Passwords are different");
            }

            return BadRequest("Old password is incorrect");
        }

        [HttpGet("GetUser")]
        [Authorize]
        public ActionResult GetUser(string username)
        {
            var user = _userContext.Users.FirstOrDefault(x => x.Username == username);

            return Ok(user);
        }


    }
}
