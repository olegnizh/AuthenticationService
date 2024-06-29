﻿using System.Collections.Generic;

namespace AuthenticationService
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAll();
		User GetByLogin(string login);
	}
}
