#pragma warning disable CS8618
namespace DojoSurveyWithModel.Models;
using System.ComponentModel.DataAnnotations;

public class Survey
{
    public string name { get; set; }
    public string dojoLocation { get; set; }
    public string favLanguage { get; set; }
    public string comment { get; set; }
}