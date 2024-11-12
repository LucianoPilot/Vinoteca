using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Vinoteca.Models
{
    public class CataUpdateInvitadosDto
    {
        public List<string> Invitados { get; set; }
    }

    

}
