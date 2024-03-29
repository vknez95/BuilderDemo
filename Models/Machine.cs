﻿using System;
using BuilderDemo.Interfaces;

namespace BuilderDemo.Models
{
    public class Machine: IUser
    {
        public Producer Producer { get; set; }
        public string Model { get; set; }

        public void SetIdentity(IUserIdentity identity)
        {
            if (!this.CanAcceptIdentity(identity))
                throw new ArgumentException();

            MacAddress address = identity as MacAddress;
            // do something with address.NicPart

        }

        public bool CanAcceptIdentity(IUserIdentity identity) =>
            identity is MacAddress;

        public Machine(Producer producer, string model)
        {
            if (producer == null)
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(model))
                throw new ArgumentException();

            this.Producer = producer;
            this.Model = model;

        }
    }
}
