﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class User : Record, IComparable<User>, IEquatable<User>, IEqualityComparer<User>
    {
        public List<UserAction> Actions { get { return Database.Where<UserAction>("|T|.user_id = {0}", this.ID); } } 

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName { get { return this.FirstName + " " + this.LastName; } }
        public virtual bool IsAuthenticated { get { return this.ID != 0; } }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }

        public User(int id, string firstName, string lastName, string username, string password, string email)
            : base(id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Username = username;
            this.Email = email;
        }

        public UserAction Login()
        {
            return new UserAction(this, "login").Create() as UserAction;
        }

        public UserAction Logout()
        {
            return new UserAction(this, "logout").Create() as UserAction;
        }

        public static User Authenticate(string name, string password)
        {
            return Database.GetUser(name, password);
        }

        public static Visitor Authenticate(string id)
        {
            return Database.GetVisitor(id);
        }

        public int CompareTo(User other)
        {
            return this.ID.CompareTo(other.ID);
        }

        public bool Equals(User other)
        {
            return this.ID == other.ID;
        }

        public bool Equals(User x, User y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(User obj)
        {
            return this.ID;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public override Record Create()
        {
            throw new NotToBeSentToDatabaseException();
        }
    }
}
