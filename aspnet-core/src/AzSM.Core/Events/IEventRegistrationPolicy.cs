using Abp.Domain.Services;
using AzSM.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AzSM.Events
{
	public interface IEventRegistrationPolicy : IDomainService
	{
		/// <summary>
		/// Checks if given user can register to <see cref="@event"/> and throws exception if can not.
		/// </summary>
		Task CheckRegistrationAttemptAsync(Event @event, User user);
	}
}
