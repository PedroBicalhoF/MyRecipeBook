using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipeBook.Application.UseCases.User.Register;

public interface IRegisterUserAccountUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserAccountJson request);
}
