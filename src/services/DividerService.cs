namespace services
{
    using domain.Dtos;
    using domain.Entidades;
    using domain.Interfaces;
    using FluentValidation;
    using global::services;
    using System;
    using System.Collections.Generic;
    using util;

    public class DividerService : IDividerService
    {
        public async DividerResponse CalculateDivider(Divider divider)
        {
            DividerResponse response = new DividerResponse();
            try
            {
                DividerValidator dividerValidator = new DividerValidator();
                var resultValidator = dividerValidator.Validate(divisor);

                if (!resultValidator.IsValid)
                {
                    response.Erro = resultValidator.Errors[0].ErrorMessage;
                    response.Ok = false;
                    return response;
                }

                for(long i = 1; i <= divider.Number;i++)
                {
                    if (Util.CheckDivider(divider.Number, i))
                    {
                        response.Dividers.Add(i);
                    }
                }

                if (divider.Prime)
                {
                    IList<long> dividerPrimes = new List<long>();
                    foreach (var item in response.Dividers)
                    {
                        if (Util.CheckPrime(item))
                        {
                            dividersPrimes.Add(item);
                        }
                    }
                    response.Dividers = dividersPrimes;
                }

                response.Ok = true;

                return response;
            }
            catch (Exception ex)
            {
                response.Erro = ex.Message;
                response.Ok = false;

                return response;
            }
        }
    }
}