using Fiap.TechChallenge.LibDomain.Entities;

namespace Fiap.TechChallenge.LibDomain.Events;

public class ContactUpdateEvent(string name, string email, string phoneNumber, short dddNumber) : ContactEntity(name, email, phoneNumber, dddNumber);