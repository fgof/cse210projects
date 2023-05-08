using System;
class Scripture
{
    private List<Word> words;
    private Reference scriptureReference;

    public Scripture (Reference _scriptureReference, string _scriptureText);
    {
        scriptureReference = _scriptureReference;
        CreateWords(_scriptureText);
    }

    private void CreateWords(string _scriptureText);
    {

    }

    public string GetScripture()
    {
        return "scripture";
    }

    public bool HasWordsLeft()
    {
        return true;
    }

    public void RemoveWords();
    {
        int noWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, words.Count());
            if (words[rndIndex].GetIsHidden() == false)
            {
                words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }

        }while (wordsRemoved != numWordsToRemove && this.HasWordsLeft());
    }

}