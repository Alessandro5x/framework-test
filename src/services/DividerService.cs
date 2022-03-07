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
        static void Main() {}
        public DividerResponse CalculateDivider(Divider divider)
        {
            DividerResponse response = new DividerResponse();
            try
            {
                DividerValidator dividerValidator = new DividerValidator();
                var resultValidator = dividerValidator.Validate(divider);

                if (!resultValidator.IsValid)
                {
                    response.Error = resultValidator.Errors[0].ErrorMessage;
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
                            dividerPrimes.Add(item);
                        }
                    }
                    response.Dividers = dividerPrimes;
                }

                response.Ok = true;

                return response;
            }
            catch (Exception ex)
            {
                response.Error = ex.Message;
                response.Ok = false;

                return response;
            }
        }
    }
}