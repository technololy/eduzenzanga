using EduZanga.Model.Dto;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace EduZanga.Shared.Pages.PortalSettings.AcademicSession;

public partial class AcademicSettings : ComponentBase
{
    [Inject] private IDialogService? DialogService { get; set; }
    private IDialogReference _dialog = null!;
    private readonly List<SessionModelDto> _sessions =
    [
        new SessionModelDto
        {
            Term = "First Term", Session = "2024/2025", IsActive = true, IsResultPublished = false,
            LastUpdated = DateTime.Now
        },
        new SessionModelDto
        {
            Term = "Second Term", Session = "2024/2025", IsActive = false, IsResultPublished = false,
            LastUpdated = DateTime.Now
        }
    ];

    private bool _selectAllChecked;

    private void OnSelectAllChange(bool isChecked)
    {
        _selectAllChecked = isChecked;
        foreach (var session in _sessions)
        {
            session.IsSelected = isChecked;
        }
    }

    private async Task OpenAddSessionDialog()
    {
        var parameters = new DialogParameters { ["SessionModel"] = new SessionModelDto() };
        var dialogOptions = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small };
        _dialog = await DialogService.ShowAsync<AddSession>("Add New Session", parameters, dialogOptions);
        var result = await _dialog.Result;

        if (!result.Canceled && result.Data is SessionModelDto newSession)
        {
            _sessions.Add(newSession);
        }
    }
}