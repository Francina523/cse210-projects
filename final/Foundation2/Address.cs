class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public string GetAddressDetails()
    {
        return $"Street Address: {StreetAddress}\nCity: {City}\nState/Province: {StateProvince}\nCountry: {Country}";
    }
}
