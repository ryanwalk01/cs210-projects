public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text, bool showFirstLetter) {
        _reference = Reference;
        string[] words = text.Split(" ");
        foreach (string word in words) {
            _words.Add(new Word(word, showFirstLetter));
        }
    }

    public void HideRandomWords(int numberToHide) {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++) {
            int wordToHide = random.Next(0,_words.Count);
            if (_words[wordToHide].IsHidden()) {
                i--;
            }
            else {
                _words[wordToHide].Hide();
            }
        }
    }

    public string GetDisplayText() {

        string text = "";
        foreach (Word word in _words) {
            string thisWord = word.GetDisplayText();
            text += $"{thisWord} ";
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden() {
        bool completelyHidden = true;
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                completelyHidden = false;
            }
        }
        return completelyHidden;
    }
}