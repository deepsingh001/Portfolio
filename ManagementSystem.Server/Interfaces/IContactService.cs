using ManagementSystem.Server.DTOs;

namespace ManagementSystem.Server.Interfaces
{
    public interface IContactService
    {
        void AddContact(CreateContactDto dto);
        List<ContactListDto> GetAllContacts();
    }
}
