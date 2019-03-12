; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "MeetTracker"
#define MyAppVersion "0.9"
#define MyAppPublisher "Isuru Rathnayake and Rukshan Perera"
#define MyAppURL "https://github.com/KRVPerera/SportsMeet"
#define MyAppExeName "SportsMeet.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4E125D40-C77B-4A39-8715-CA0BA30CA24B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=..\LICENSE
InfoBeforeFile=InformationPre.txt
InfoAfterFile=InformationPost.txt
OutputBaseFilename=MeetSetup
Compression=lzma
SolidCompression=yes
MinVersion=0,6.0
VersionInfoVersion=0.9
VersionInfoCompany=ISURU RATHNAYAKA and RUKSHAN PERERA
VersionInfoCopyright=2019
VersionInfoProductName=MeetTracker
VersionInfoProductVersion=0.9

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "..\SportsMeet\bin\Debug\System.Data.SQLite.dll"; DestDir: "{app}"
Source: "..\SportsMeet\bin\Debug\Dapper.dll"; DestDir: "{app}"
Source: "..\SportsMeet\bin\Debug\x86\SQLite.Interop.dll"; DestDir: "{app}\x86"
Source: "..\SportsMeet\bin\Debug\x64\SQLite.Interop.dll"; DestDir: "{app}\x64"
Source: "..\SportsMeet\bin\Debug\x86\SQLite.Interop.dll"; DestDir: "{tmp}\MeetTracker\x86"
Source: "..\SportsMeet\bin\Debug\x64\SQLite.Interop.dll"; DestDir: "{tmp}\MeetTracker\x64"
Source: "..\MeetDataBaseGen\bin\Debug\dbup-core.dll"; DestDir: "{tmp}\MeetTracker"
Source: "..\MeetDataBaseGen\bin\Debug\dbup-sqlite.dll"; DestDir: "{tmp}\MeetTracker"
Source: "..\SportsMeet\bin\Debug\System.Data.SQLite.dll"; DestDir: "{tmp}\MeetTracker"
Source: "dependencies\dotNetFx40_Full_x86_x64.exe"; DestDir: "{app}"; Flags: deleteafterinstall; Check: FrameworkIsNotInstalled; AfterInstall: InstallFramework

Source: "..\MeetDataBaseGen\bin\Debug\MeetDataBaseGen.exe.config"; DestDir: "{tmp}\MeetTracker"; Flags: ignoreversion
Source: "..\MeetDataBaseGen\bin\Debug\MeetDataBaseGen.exe"; DestDir: "{tmp}\MeetTracker"; Flags: ignoreversion deleteafterinstall; AfterInstall: CreateMeetDatabase
Source: "..\SportsMeet\bin\Debug\SportsMeet.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\SportsMeet\bin\Debug\SportsMeet.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\SportsMeet\bin\Debug\Dapper.Contrib.dll"; DestDir: "{app}"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[ThirdParty]
;https://stackoverflow.com/questions/20752882/how-can-i-install-net-framework-as-a-prerequisite-using-innosetup
UseRelativePaths=True

[Code]
procedure InstallFramework;
var
  ResultCode: Integer;
begin
  if not Exec(ExpandConstant('{tmp}\dotNetFx40_Full_x86_x64.exe'), '/q /norestart', '', SW_SHOW, ewWaitUntilTerminated, ResultCode) then
  begin
    { you can interact with the user that the installation failed }
    MsgBox('.NET installation failed with code: ' + IntToStr(ResultCode) + '.',
      mbError, MB_OK);
  end;
end;

procedure CreateMeetDatabase;
var
  ResultCode: Integer;
begin
  if not Exec(ExpandConstant('{tmp}\MeetTracker\MeetDataBaseGen.exe'), '', '', SW_SHOW, ewWaitUntilTerminated, ResultCode) then
  begin
    { you can interact with the user that the installation failed }
    MsgBox('Database schema generation failed with code: ' + IntToStr(ResultCode) + '.',
      mbError, MB_OK);
  end;
  DelTree(ExpandConstant('{tmp}\MeetTracker'), True, True, True);
end;


function FrameworkIsNotInstalled: Boolean;
begin
  Result := not RegKeyExists(HKEY_LOCAL_MACHINE, 'Software\Microsoft\.NETFramework\policy\v4.0');
end;

procedure CurUninstallStepChanged (CurUninstallStep: TUninstallStep);
var
  mres : integer;
begin
  case CurUninstallStep of
    usPostUninstall:
      begin
        mres := MsgBox('Do you want to delete saved files?', mbConfirmation, MB_YESNO or MB_DEFBUTTON2)
        if mres = IDYES then
          DelTree(ExpandConstant('{userdocs}\MyApp'), True, True, True);
      end;  
  end;
end;