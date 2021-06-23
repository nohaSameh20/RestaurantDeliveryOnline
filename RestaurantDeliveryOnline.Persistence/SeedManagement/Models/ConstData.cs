using System.Collections.Generic;
using System.Linq;

namespace RestaurantDeliveryOnline.Presistence.Data
{
    public class ConstData
    {
        public List<CountrySD> COUNTRIES
        {
            get
            {
                {
                    var countries = new List<CountrySD>();

                    countries.Add(new CountrySD("km", "269", "Comoros"));
                    countries.Add(new CountrySD("as", "1", "American Samoa"));
                    countries.Add(new CountrySD("ad", "376", "Andorra"));
                    countries.Add(new CountrySD("af", "93", "Afghanistan"));
                    countries.Add(new CountrySD("ag", "1", "Antigua and Barbuda"));
                    countries.Add(new CountrySD("ai", "1", "Anguilla"));
                    countries.Add(new CountrySD("al", "355", "Albania"));
                    countries.Add(new CountrySD("am", "374", "Armenia"));
                    countries.Add(new CountrySD("ao", "244", "Angola"));
                    countries.Add(new CountrySD("aq", "672", "Antarctica"));
                    countries.Add(new CountrySD("ar", "54", "Argentina"));
                    countries.Add(new CountrySD("ax", "358", "Åland Islands"));
                    countries.Add(new CountrySD("az", "994", "Azerbaijan"));
                    countries.Add(new CountrySD("ba", "387", "Bosnia And Herzegovina"));
                    countries.Add(new CountrySD("bb", "1", "Barbados"));
                    countries.Add(new CountrySD("bd", "880", "Bangladesh"));
                    countries.Add(new CountrySD("be", "32", "Belgium"));
                    countries.Add(new CountrySD("bf", "226", "Burkina Faso"));
                    countries.Add(new CountrySD("bg", "359", "Bulgaria"));
                    countries.Add(new CountrySD("bi", "257", "Burundi"));
                    countries.Add(new CountrySD("bj", "229", "Benin"));
                    countries.Add(new CountrySD("bl", "590", "Saint Barthélemy"));
                    countries.Add(new CountrySD("bm", "1", "Bermuda"));
                    countries.Add(new CountrySD("bn", "673", "Brunei Darussalam"));
                    countries.Add(new CountrySD("bo", "591", "Bolivia, Plurinational State Of"));
                    countries.Add(new CountrySD("bs", "1", "Bahamas"));
                    countries.Add(new CountrySD("bt", "975", "Bhutan"));
                    countries.Add(new CountrySD("bw", "267", "Botswana"));
                    countries.Add(new CountrySD("by", "375", "Belarus"));
                    countries.Add(new CountrySD("bz", "501", "Belize"));
                    countries.Add(new CountrySD("cc", "61", "Cocos (keeling) Islands"));
                    countries.Add(new CountrySD("cd", "243", "Congo, The Democratic Republic Of The"));
                    countries.Add(new CountrySD("cf", "236", "Central African Republic"));
                    countries.Add(new CountrySD("cg", "242", "Congo"));
                    countries.Add(new CountrySD("ch", "41", "Switzerland"));
                    countries.Add(new CountrySD("ci", "225", "Côte D'ivoire"));
                    countries.Add(new CountrySD("ck", "682", "Cook Islands"));
                    countries.Add(new CountrySD("cl", "56", "Chile"));
                    countries.Add(new CountrySD("cm", "237", "Cameroon"));
                    countries.Add(new CountrySD("co", "57", "Colombia"));
                    countries.Add(new CountrySD("cr", "506", "Costa Rica"));
                    countries.Add(new CountrySD("cu", "53", "Cuba"));
                    countries.Add(new CountrySD("cv", "238", "Cape Verde"));
                    countries.Add(new CountrySD("cw", "599", "Curaçao"));
                    countries.Add(new CountrySD("cx", "61", "Christmas Island"));
                    countries.Add(new CountrySD("cy", "357", "Cyprus"));
                    countries.Add(new CountrySD("cz", "420", "Czech Republic"));
                    countries.Add(new CountrySD("dm", "1", "Dominica"));
                    countries.Add(new CountrySD("do", "1", "Dominican Republic"));
                    countries.Add(new CountrySD("dz", "213", "Algeria"));
                    countries.Add(new CountrySD("ec", "593", "Ecuador"));
                    countries.Add(new CountrySD("ee", "372", "Estonia"));
                    countries.Add(new CountrySD("er", "291", "Eritrea"));
                    countries.Add(new CountrySD("et", "251", "Ethiopia"));
                    countries.Add(new CountrySD("fi", "358", "Finland"));
                    countries.Add(new CountrySD("fj", "679", "Fiji"));
                    countries.Add(new CountrySD("fk", "500", "Falkland Islands (malvinas)"));
                    countries.Add(new CountrySD("fm", "691", "Micronesia, Federated States Of"));
                    countries.Add(new CountrySD("fo", "298", "Faroe Islands"));
                    countries.Add(new CountrySD("ga", "241", "Gabon"));
                    countries.Add(new CountrySD("gd", "1", "Grenada"));
                    countries.Add(new CountrySD("ge", "995", "Georgia"));
                    countries.Add(new CountrySD("gf", "594", "French Guyana"));
                    countries.Add(new CountrySD("gh", "233", "Ghana"));
                    countries.Add(new CountrySD("gi", "350", "Gibraltar"));
                    countries.Add(new CountrySD("gl", "299", "Greenland"));
                    countries.Add(new CountrySD("gm", "220", "Gambia"));
                    countries.Add(new CountrySD("gn", "224", "Guinea"));
                    countries.Add(new CountrySD("gp", "450", "Guadeloupe"));
                    countries.Add(new CountrySD("gq", "240", "Equatorial Guinea"));
                    countries.Add(new CountrySD("gr", "30", "Greece"));
                    countries.Add(new CountrySD("gt", "502", "Guatemala"));
                    countries.Add(new CountrySD("gu", "1", "Guam"));
                    countries.Add(new CountrySD("gw", "245", "Guinea-bissau"));
                    countries.Add(new CountrySD("gy", "592", "Guyana"));
                    countries.Add(new CountrySD("hk", "852", "Hong Kong"));
                    countries.Add(new CountrySD("hn", "504", "Honduras"));
                    countries.Add(new CountrySD("hr", "385", "Croatia"));
                    countries.Add(new CountrySD("ht", "509", "Haiti"));
                    countries.Add(new CountrySD("hu", "36", "Hungary"));
                    countries.Add(new CountrySD("id", "62", "Indonesia"));
                    countries.Add(new CountrySD("ie", "353", "Ireland"));
                    countries.Add(new CountrySD("im", "44", "Isle Of Man"));
                    countries.Add(new CountrySD("is", "354", "Iceland"));
                    countries.Add(new CountrySD("io", "246", "British Indian Ocean Territory"));
                    countries.Add(new CountrySD("ir", "98", "Iran, Islamic Republic Of"));
                    countries.Add(new CountrySD("je", "44", "Jersey"));
                    countries.Add(new CountrySD("ke", "254", "Kenya"));
                    countries.Add(new CountrySD("kg", "996", "Kyrgyzstan"));
                    countries.Add(new CountrySD("kh", "855", "Cambodia"));
                    countries.Add(new CountrySD("ki", "686", "Kiribati"));
                    countries.Add(new CountrySD("kn", "1", "Saint Kitts and Nevis"));
                    countries.Add(new CountrySD("kp", "850", "North Korea"));
                    countries.Add(new CountrySD("kr", "82", "South Korea"));
                    countries.Add(new CountrySD("ky", "1", "Cayman Islands"));
                    countries.Add(new CountrySD("kz", "7", "Kazakhstan"));
                    countries.Add(new CountrySD("la", "856", "Lao People's Democratic Republic"));
                    countries.Add(new CountrySD("lc", "1", "Saint Lucia"));
                    countries.Add(new CountrySD("li", "423", "Liechtenstein"));
                    countries.Add(new CountrySD("lk", "94", "Sri Lanka"));
                    countries.Add(new CountrySD("lr", "231", "Liberia"));
                    countries.Add(new CountrySD("ls", "266", "Lesotho"));
                    countries.Add(new CountrySD("lt", "370", "Lithuania"));
                    countries.Add(new CountrySD("lu", "352", "Luxembourg"));
                    countries.Add(new CountrySD("lv", "371", "Latvia"));
                    countries.Add(new CountrySD("mc", "377", "Monaco"));
                    countries.Add(new CountrySD("md", "373", "Moldova, Republic Of"));
                    countries.Add(new CountrySD("me", "382", "Montenegro"));
                    countries.Add(new CountrySD("mf", "590", "Saint Martin"));
                    countries.Add(new CountrySD("mg", "261", "Madagascar"));
                    countries.Add(new CountrySD("mh", "692", "Marshall Islands"));
                    countries.Add(new CountrySD("mk", "389", "Macedonia (FYROM)"));
                    countries.Add(new CountrySD("ml", "223", "Mali"));
                    countries.Add(new CountrySD("mm", "95", "Myanmar"));
                    countries.Add(new CountrySD("mn", "976", "Mongolia"));
                    countries.Add(new CountrySD("mo", "853", "Macau"));
                    countries.Add(new CountrySD("mp", "1", "Northern Mariana Islands"));
                    countries.Add(new CountrySD("mq", "596", "Martinique"));
                    countries.Add(new CountrySD("ms", "1", "Montserrat"));
                    countries.Add(new CountrySD("mt", "356", "Malta"));
                    countries.Add(new CountrySD("mu", "230", "Mauritius"));
                    countries.Add(new CountrySD("mv", "960", "Maldives"));
                    countries.Add(new CountrySD("mw", "265", "Malawi"));
                    countries.Add(new CountrySD("mx", "52", "Mexico"));
                    countries.Add(new CountrySD("mz", "258", "Mozambique"));
                    countries.Add(new CountrySD("na", "264", "Namibia"));
                    countries.Add(new CountrySD("nc", "687", "New Caledonia"));
                    countries.Add(new CountrySD("ne", "227", "Niger"));
                    countries.Add(new CountrySD("nf", "672", "Norfolk Islands"));
                    countries.Add(new CountrySD("ng", "234", "Nigeria"));
                    countries.Add(new CountrySD("ni", "505", "Nicaragua"));
                    countries.Add(new CountrySD("nl", "31", "Netherlands"));
                    countries.Add(new CountrySD("no", "47", "Norway"));
                    countries.Add(new CountrySD("np", "977", "Nepal"));
                    countries.Add(new CountrySD("nr", "674", "Nauru"));
                    countries.Add(new CountrySD("nu", "683", "Niue"));
                    countries.Add(new CountrySD("nz", "64", "New Zealand"));
                    countries.Add(new CountrySD("pa", "507", "Panama"));
                    countries.Add(new CountrySD("pe", "51", "Peru"));
                    countries.Add(new CountrySD("pf", "689", "French Polynesia"));
                    countries.Add(new CountrySD("pg", "675", "Papua New Guinea"));
                    countries.Add(new CountrySD("ph", "63", "Philippines"));
                    countries.Add(new CountrySD("pk", "92", "Pakistan"));
                    countries.Add(new CountrySD("pl", "48", "Poland"));
                    countries.Add(new CountrySD("pm", "508", "Saint Pierre And Miquelon"));
                    countries.Add(new CountrySD("pn", "870", "Pitcairn Islands"));
                    countries.Add(new CountrySD("pr", "1", "Puerto Rico"));
                    countries.Add(new CountrySD("pt", "351", "Portugal"));
                    countries.Add(new CountrySD("pw", "680", "Palau"));
                    countries.Add(new CountrySD("py", "595", "Paraguay"));
                    countries.Add(new CountrySD("re", "262", "Réunion"));
                    countries.Add(new CountrySD("ro", "40", "Romania"));
                    countries.Add(new CountrySD("rs", "381", "Serbia"));
                    countries.Add(new CountrySD("rw", "250", "Rwanda"));
                    countries.Add(new CountrySD("sb", "677", "Solomon Islands"));
                    countries.Add(new CountrySD("sc", "248", "Seychelles"));
                    countries.Add(new CountrySD("sg", "65", "Singapore"));
                    countries.Add(new CountrySD("sh", "290", "Saint Helena, Ascension And Tristan Da Cunha"));
                    countries.Add(new CountrySD("si", "386", "Slovenia"));
                    countries.Add(new CountrySD("sk", "421", "Slovakia"));
                    countries.Add(new CountrySD("sl", "232", "Sierra Leone"));
                    countries.Add(new CountrySD("sm", "378", "San Marino"));
                    countries.Add(new CountrySD("sn", "221", "Senegal"));
                    countries.Add(new CountrySD("sr", "597", "Suriname"));
                    countries.Add(new CountrySD("ss", "211", "South Sudan"));
                    countries.Add(new CountrySD("st", "239", "Sao Tome And Principe"));
                    countries.Add(new CountrySD("sv", "503", "El Salvador"));
                    countries.Add(new CountrySD("sx", "1", "Sint Maarten"));
                    countries.Add(new CountrySD("sz", "268", "Swaziland"));
                    countries.Add(new CountrySD("tc", "1", "Turks and Caicos Islands"));
                    countries.Add(new CountrySD("td", "235", "Chad"));
                    countries.Add(new CountrySD("tg", "228", "Togo"));
                    countries.Add(new CountrySD("tj", "992", "Tajikistan"));
                    countries.Add(new CountrySD("tk", "690", "Tokelau"));
                    countries.Add(new CountrySD("tl", "670", "Timor-leste"));
                    countries.Add(new CountrySD("tm", "993", "Turkmenistan"));
                    countries.Add(new CountrySD("to", "676", "Tonga"));
                    countries.Add(new CountrySD("tt", "1", "Trinidad &amp; Tobago"));
                    countries.Add(new CountrySD("tv", "688", "Tuvalu"));
                    countries.Add(new CountrySD("tw", "886", "Taiwan"));
                    countries.Add(new CountrySD("tz", "255", "Tanzania, United Republic Of"));
                    countries.Add(new CountrySD("ug", "256", "Uganda"));
                    countries.Add(new CountrySD("uy", "598", "Uruguay"));
                    countries.Add(new CountrySD("uz", "998", "Uzbekistan"));
                    countries.Add(new CountrySD("va", "379", "Holy See (vatican City State)"));
                    countries.Add(new CountrySD("vc", "1", "Saint Vincent &amp; The Grenadines"));
                    countries.Add(new CountrySD("ve", "58", "Venezuela, Bolivarian Republic Of"));
                    countries.Add(new CountrySD("vg", "1", "British Virgin Islands"));
                    countries.Add(new CountrySD("vi", "1", "US Virgin Islands"));
                    countries.Add(new CountrySD("vn", "84", "Vietnam"));
                    countries.Add(new CountrySD("vu", "678", "Vanuatu"));
                    countries.Add(new CountrySD("wf", "681", "Wallis And Futuna"));
                    countries.Add(new CountrySD("ws", "685", "Samoa"));
                    countries.Add(new CountrySD("xk", "383", "Kosovo"));
                    countries.Add(new CountrySD("yt", "262", "Mayotte"));

                    countries.Add(new CountrySD("zm", "260", "Zambia"));
                    countries.Add(new CountrySD("zw", "263", "Zimbabwe"));

                    countries = countries.OrderBy(obj => obj.Name).ToList();
                    return countries;
                }
            }
        }

        public List<KeyValuePair<string, string>> EGYPTCITIES => new List<KeyValuePair<string, string>>()
           {
               new KeyValuePair<string, string>("Cairo","القاهرة"),
               new KeyValuePair<string, string>("Giza","الجيزة"),
               new KeyValuePair<string, string>("Alexandria","الأسكندرية"),
               new KeyValuePair<string, string>("Dakahlia","الدقهلية"),
               new KeyValuePair<string, string>("Red Sea","البحر الأحمر"),
               new KeyValuePair<string, string>("Beheira","البحيرة"),
               new KeyValuePair<string, string>("Fayoum","الفيوم"),
               new KeyValuePair<string, string>("Gharbiya","الغربية"),
               new KeyValuePair<string, string>("Ismailia","الإسماعلية"),
               new KeyValuePair<string, string>("Monofia","المنوفية"),
               new KeyValuePair<string, string>("Minya","المنيا"),
               new KeyValuePair<string, string>("Qaliubiya","القليوبية"),
               new KeyValuePair<string, string>("New Valley","الوادي الجديد"),
               new KeyValuePair<string, string>("Suez","السويس"),
               new KeyValuePair<string, string>("Aswan","اسوان"),
               new KeyValuePair<string, string>("Assiut","اسيوط"),
               new KeyValuePair<string, string>("Beni Suef","بني سويف"),
               new KeyValuePair<string, string>("Port Said","بورسعيد"),
               new KeyValuePair<string, string>("Damietta","دمياط"),
               new KeyValuePair<string, string>("Sharkia","الشرقية"),
               new KeyValuePair<string, string>("South Sinai","جنوب سيناء"),
               new KeyValuePair<string, string>("Kafr Al sheikh","كفر الشيخ"),
               new KeyValuePair<string, string>("Matrouh","مطروح"),
               new KeyValuePair<string, string>("Luxor","الأقصر"),
               new KeyValuePair<string, string>("Qena","قنا"),
               new KeyValuePair<string, string>("North Sinai","شمال سيناء"),
               new KeyValuePair<string, string>("Sohag","سوهاج"),
           };

    }
}
