﻿using AutoMapper;
using Demo.PL.ViewModels;
using DemoDAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
	[Authorize]
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<ApplicationUser> userManager,
			IMapper mapper)
        {
			_userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string SearchValue)
		{
			if (string.IsNullOrEmpty(SearchValue))
			{
				var Users=await _userManager.Users.Select(
					U=>new UsersViewModel()
					{
						Id = U.Id,
						FName = U.FName,
						LName = U.LName,
						Email = U.Email,
						PhoneNumber = U.PhoneNumber,
						Roles=  _userManager.GetRolesAsync(U).Result,
					}).ToListAsync();
				return View(Users);

			}
			else
			{
				var User=await _userManager.FindByEmailAsync(SearchValue);
				var MappedUser = new UsersViewModel()
				{
					Id = User.Id,
					FName = User.FName,
					LName = User.LName,
					Email = User.Email,
					PhoneNumber = User.PhoneNumber,
					Roles = await _userManager.GetRolesAsync(User),
				};
			return View(new List<UsersViewModel> { MappedUser});
			}
		}

		public async Task<IActionResult> Details(string Id, string ViewName = "Details")
		{
			if (Id is null)
				return BadRequest();
			var User = await _userManager.FindByIdAsync(Id);
			if (User is null)
				return NotFound();
			var MappedUser = _mapper.Map<ApplicationUser, UsersViewModel>(User);
			return View(ViewName,MappedUser);
		}

		[HttpGet]
		public async Task<IActionResult> Edit(string Id) 
		{
			return await Details(Id, "Edit");
		}
		[HttpPost]
		public async Task<IActionResult> Edit(UsersViewModel model,[FromRoute]string Id)
		{
			if (Id != model.Id)
				return BadRequest();
			if(ModelState.IsValid)
			{
				try
				{
				  var User=  await	_userManager.FindByIdAsync(Id);
					User.PhoneNumber = model.PhoneNumber;
					User.FName = model.FName;
					User.LName = model.LName;
 					await _userManager.UpdateAsync(User);
					return RedirectToAction(nameof(Index));
				}
				catch(Exception ex)
				{
                    ModelState.AddModelError(string.Empty, ex.Message);

                }
			}
			return View(model);
		}

		public async Task<IActionResult> Delete(string Id) 
		{
			return await Details(Id, "Delete");
		}
		[HttpPost]
		public async Task<IActionResult> ConfirmDelete(string Id)
		{
			try
			{ 
				var User = await _userManager.FindByIdAsync(Id);
				await _userManager.DeleteAsync(User);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex) 
			{ 
				ModelState.AddModelError(string.Empty,ex.Message);
				return RedirectToAction("Error", "Home");
			}
		}
	}
}
