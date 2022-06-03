using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands;

public class InsertPersonCommandClass : IRequest<PersonModel>
{
    // capitalize because of IRequest mapping 
    public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
    
    
    // public string FirstName { get; set; }
    // public string LastName { get; set; }
    //
    // public InsertPersonCommandClass(string firstName, string lastName)
    // {
    //     FirstName = firstName;
    //     LastName = lastName;
    // }
}