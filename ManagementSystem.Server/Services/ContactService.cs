using System;
using System.Collections.Generic;
using System.Linq;
using ManagementSystem.Server.Data;
using ManagementSystem.Server.DTOs;
using ManagementSystem.Server.Interfaces;
using ManagementSystem.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Server.Services
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext _context;

        public ContactService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddContact(CreateContactDto dto)
        {
            // Check if Gmail already exists (active contact)
            var exists = _context.Contacts
                .Any(x => x.Email == dto.Email && !x.IsDeleted);

            if (exists)
                throw new Exception("This Gmail address is already used");

            var ExitNum = _context.Contacts.Any(X => X.Phone == dto.Phone && !X.IsDeleted);

            if (ExitNum)
                throw new Exception("This Contact Number Is Already Used");

            var contact = new Contact
            {
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                Address = dto.Address,
                Message = dto.Message,
                IsDeleted = true,   // new contact is active
                SubmittedAt = DateTime.Now,
                deletedAt = null,
                updateAt = null
            };

            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }


        // Get all active contacts
        public List<ContactListDto> GetAllContacts()
        {
            return _context.Contacts
                .Where(x => !x.IsDeleted)
                .Select(x => new ContactListDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Email = x.Email,
                    Phone = x.Phone,
                    Message = x.Message,
                    SubmittedAt = x.SubmittedAt
                })
                .AsNoTracking()
                .ToList();
        }
    }
}
