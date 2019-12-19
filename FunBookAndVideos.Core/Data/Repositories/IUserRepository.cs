using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FunBookAndVideos.Core.Entitties;
using FunBookAndVideos.Core.Exceptions;

namespace FunBookAndVideos.Core.Data.Repositories
{
    public interface IUserRepository
    {
        Customer GetUserById(long userId);
        void Add(Customer customer);
        void Update(Customer customer);
        void AddMembership(long userID, List<Membership> memberships)
        void AddMembership(Customer customer, Membership membership);

    }

    public class UserRepository : IUserRepository
    {
        private readonly Dictionary<long, Customer> _users;


        public UserRepository()
        {
            _users = new Dictionary<long, Customer>();
        }

        public Customer GetUserById(long userId)
        {
            if (_users.TryGetValue(userId, out var user)) return user;
            throw new UserDoesNotExist();
        }

        public void Add(Customer customer)
        {
            if (_users.TryAdd(customer.CustomerId, customer)) return;
            throw new UserDoesNotExist();
        }

        //TODO: update dictionary
        public void Update(Customer customer)
        {
            if (!_users.ContainsKey(customer.CustomerId))
                throw new UserDoesNotExist();
            _users.Remove(customer.CustomerId);
            _users.Add(customer.CustomerId, customer);

        }

        public void AddMembership(long userID, List<Membership> memberships)
        {
            var user = GetUserById(userID);
            foreach (var membership in memberships)
            {
                AddMembership(user, membership);
            }
        }

        public void AddMembership(Customer customer, Membership membership)
        {
            if (customer.Memberships.Contains(membership)) return;
            customer.Memberships.Add(membership);
            Update(customer);
        }
    }
}
