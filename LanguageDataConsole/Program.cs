using PSC.CSharp.Library.LanguageData;

var languageHelper = new LanguageHelper();

Console.WriteLine("Check for en code...");
var language = languageHelper.GetLanguage("en");
if (language != null)
{
    Console.WriteLine($"Language Name: {language.LanguageName}");
    Console.WriteLine($"Language Native: {language.LanguageNative}");
}

Console.WriteLine("\n\nCheck for German code...");
Console.WriteLine($"Language Name: {languageHelper.GetLanguageName("de")}");
Console.WriteLine($"Language Native: {languageHelper.GetLanguageNative("de")}");
Console.WriteLine($"ISO 639-2 B: {languageHelper.GetLanguageCode6392B("de")}");
Console.WriteLine($"ISO 639-2 T: {languageHelper.GetLanguageCode6392T("de")}");
Console.WriteLine($"Direction: {languageHelper.GetLanguageDirection("de")}");
Console.WriteLine($"Script: {languageHelper.GetLanguageScript("de")}");