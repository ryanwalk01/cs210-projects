public class Word {
    private string _text;
    private bool _isHidden;
    private bool _showFirstLetter;

    public Word(string text, bool showFirstLetter) {
        _text = text;
        _isHidden = false;
        _showFirstLetter = showFirstLetter;
    }

    public void Hide() {
        _isHidden = true;
    }

    public void Show() {
        _isHidden = false;
    }

    public bool IsHidden() {
        return _isHidden;
    }

    public string GetDisplayText() {
        char firstLetter = _text[0];
        if (_isHidden) {
            if (_showFirstLetter) {
            return $"{firstLetter}____";
            }
            else {
                return $"_____";
            }
        }
        else {
            return _text;
        }
    }
}