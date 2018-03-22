using System;
using System.Collections.Generic;
using System.Text;

public class PriceCalculator
{
    private decimal pricePerNight;
    private int nights;
    private SeasonsMultiplier seasonMultiplier;
    private Discounts discount;

    public PriceCalculator(string command)
    {
        var splitCommand = command.Split();
        pricePerNight = decimal.Parse(splitCommand[0]);
        nights = int.Parse(splitCommand[1]);
        seasonMultiplier = Enum.Parse<SeasonsMultiplier>(splitCommand[2]);
        discount = Discounts.None;
        if (splitCommand.Length > 3)
        {
            discount = Enum.Parse<Discounts>(splitCommand[3]);
        }
    }
    public string CalculatePrice()
    {
        var tempTotal = pricePerNight * nights * (int)seasonMultiplier;
        var discountPrs = ((decimal) 100 - (int) discount) / 100;
        var totalPrice = tempTotal * discountPrs;
        return totalPrice.ToString("F2");
    } 
}