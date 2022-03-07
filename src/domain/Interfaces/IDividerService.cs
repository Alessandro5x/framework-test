namespace domain.Interfaces
{
    using domain.Dtos;
    using domain.Entidades;
    using System.Collections.Generic;
    
    public interface IDividerService
    {
        DividerResponse CalculateDivider (Divider divider);
    }
}