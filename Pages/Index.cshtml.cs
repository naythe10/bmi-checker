using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

public class IndexModel : PageModel
{
    [BindProperty]
    public string name { get; set; }

    [BindProperty]
    public int age { get; set; }

    [BindProperty]
    public int height { get; set; }

    [BindProperty]
    public int weight { get; set; }

    [BindProperty]
    public int Score { get; set; }

    [BindProperty]
    public string Result { get; set; }

    [BindProperty]
    public string BMI { get; set; }
    public void OnPost()
    {
        //string Result;
        if (weight <= 18 && weight >= 0)
        {
            BMI = "Underweight";
        }
        else if (weight > 18 && weight <= 45)
        {
            BMI = "Normal";
        }
        else if (weight > 45 && weight <= 30)
        {
            BMI = "Overweight";
        }
        else if (weight > 30 && weight <= 40)
        {
            BMI = "Obese";
        }
        else if (weight > 40)
        {
            BMI = "wait... Are you even human?";
        }
        else
        {
            BMI = "Please enter something valid";
        }

        Result = $"Hello, {name}! You're height is {height} inches, weight is {weight}kgs \nSo your BMI IS {BMI}";
    }
}