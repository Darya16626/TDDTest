using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

[TestClass]
public class TDDTests
{
    private TestClass _analyzer;

    [TestInitialize]
    public void Setup()  //  метод будет выполнен перед каждым тестом
    {
        _analyzer = new TestClass(); // инициализация экземпляра
    }

    [TestMethod]
    public void TestFindShortestWord()
    {
        Assert.AreEqual("a", _analyzer.FindShortestWord("apple banana a cherry")); // метод находит самое короткое слово в строке
        Assert.AreEqual(string.Empty, _analyzer.FindShortestWord(string.Empty));  
        Assert.AreEqual(string.Empty, _analyzer.FindShortestWord("   "));
    }

    [TestMethod]
    public void TestCountWords()
    {
        Assert.AreEqual(4, _analyzer.CountWords("apple banana a cherry"));  //  метод правильно считает количество слов в строке
        Assert.AreEqual(0, _analyzer.CountWords(string.Empty));
        Assert.AreEqual(0, _analyzer.CountWords("   "));
    }

    [TestMethod]
    public void TestCountCharacters()
    {
        Assert.AreEqual(22, _analyzer.CountCharacters("apple banana a cherry"));  // метод правильно считает количество символов в строке
        Assert.AreEqual(0, _analyzer.CountCharacters(string.Empty));
    }

    [TestMethod]
    public void TestFindNinthCharacter()
    {
        Assert.AreEqual('i', _analyzer.FindNinthCharacter("abcdefghij")); // метод возвращает 9 символ строки
        Assert.IsNull(_analyzer.FindNinthCharacter("short"));
    }

    [TestMethod]
    public void TestCountDigits()
    {
        Assert.AreEqual(5, _analyzer.CountDigits("abc12345def678"));  // метод правильно считает количество цифр в строке
        Assert.AreEqual(0, _analyzer.CountDigits("abcde"));
    }

    [TestMethod]
    public void TestCountConsecutiveDigits()
    {
        Assert.AreEqual(5, _analyzer.CountConsecutiveDigits("abc12345def678")); // метод находит максимальное количество идущих цифр
        Assert.AreEqual(0, _analyzer.CountConsecutiveDigits("abcde"));
    }

    [TestMethod]
    public void TestCountOccurrencesOfAm()
    {
        Assert.AreEqual(2, _analyzer.CountOccurrencesOfAm("мама мыла раму, а ам")); // метод считает количество вхождений ам в строке
        Assert.AreEqual(0, _analyzer.CountOccurrencesOfAm("мама мыла раму"));
    }
}