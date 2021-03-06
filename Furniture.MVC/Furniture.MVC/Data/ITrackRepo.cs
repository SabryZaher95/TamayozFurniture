﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture.MVC.Models;
namespace Furniture.MVC.Data
{
    public interface ITrackRepo
    {
        Task<List<Ksacity>> GetKsacities();
        Task<List<Service>> GetServices();
        Task<List<UsersComment>> GetComments();
        Task<UsersComment> AddtComment(UsersComment comment);
        Task<RequestService> AddOrder(RequestService order);
        Task<double?> GetAverageRate();
        Task<int> GetCommentCount();
        Task<List<Announcement>> GetAnnounces();
        Task<bool> SaveChanges();
        Task<User> Login(string userName, string password);
    }
}
