using CodeSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class TranslationHelper
{
    private static Dictionary<string, string> _currentTranslations;

    public static void LoadLanguage(string languageCode)
    {
        // Construct the file path for the selected language
        string filePath = $"D:/Visual Studio Projects/CodeSystem/Translations/translation_{languageCode}.json";

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Translation file not found: {filePath}");
        }

        // Load and parse the JSON file
        var json = File.ReadAllText(filePath);
        _currentTranslations = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
    }

    public static string Translate(string key)
    {
        if (_currentTranslations != null && _currentTranslations.ContainsKey(key))
        {
            return _currentTranslations[key];
        }
        return key; // Return key if translation is not found
    }
}
