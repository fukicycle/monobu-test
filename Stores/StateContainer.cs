using System;

namespace monobu_test.Stores;

public sealed class StateContainer
{
    private string? _user;
    public string User
    {
        get => _user ?? string.Empty;
        set
        {
            _user = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
