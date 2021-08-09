# Beispiel: API-Zugriff auf Financial Lighthouse

Das Beispiel zeigt den Zugriff auf die Financial Lighthouse API mit .NET. Im Besonderen wird:

1. Ein Plan...
   1. aus der API Abgerufen
   2. aus einer JSON-Datein geladen
   3. programmatisch erzeugt
2. Eine Finanzauswertung erzeugt
3. Die Auswertung tabellarisch dargestellt

## Konfiguration

Das Beispiel benötigt einen gültigen Zugang zu Financial Lighthouse und die Zugangsdaten eines API-Client. Um einen API-Client zu erzeugen:

1. Rufen Sie das [Administrationsportal](https://www.financial-lighthouse.de/admin) auf.
2. Klicken Sie auf "Entwicklerportal" in der Navigation rechts oben Sollten Sie den Eintrag nicht sehen, weisen Sie sich oder Ihr Administrator Sie einer Gruppe zu, die das Recht "Zugriff auf den Entwicklerbereich." besitzt:
    1. Zugang → Gruppen
    2. Eine neue Gruppe erzeugen oder eine bestehende anklicken
    3. Auf der Detailseite der Gruppe den Tab Berechtigungen wählen
    4. "Zugriff auf den Entwicklerbereich" wählen (`admin:dev`)
3. Erzeugen Sie im Entwicklerportal unter "Clients" einen neuen Client vom Typ "API Zugriff"
4. Notieren Sie sich *ID* und *Secret*
5. Wählen Sie im Tab "Berechtigungen" der Detailsansicht des Clients: "Vollzugriff auf die Finanzplanung." (`financial`)

Passen Sie dann die Einstellungen in `appsettings.json` an:

```json
{
  "OAuth": {
    // Die Werte sind der Detailansicht eines Clients im Entwicklerportal zu entnehmen.
    "ClientId": "<Ihre Client ID>",
    "ClientSecret": "<Ihr Client Secret>",
    // Der Client muss diese Scopes unterstützen. Siehe Tab "Berechtigungen" in der
    // Detailansicht eines Clients im Entwicklerportal
    "Scope": "financial"
  }
}
```
