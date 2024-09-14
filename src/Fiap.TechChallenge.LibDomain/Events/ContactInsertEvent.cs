using Fiap.TechChallenge.LibDomain.Entities;

namespace Fiap.TechChallenge.LibDomain.Events;

public class ContactInsertEvent(string name, string email, string phoneNumber, short dddNumber) : ContactEntity(name, email, phoneNumber, dddNumber);