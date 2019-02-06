function longestCountryName(countries) {
    let countryName = '';

    countries.forEach((country, index) => {
        country = country || '';

        if (country.length > countryName.length) {
            countryName = country;
        }
    });

    return countryName;
}