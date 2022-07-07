# mathscientific.com/lt page testing project

## Setup
### Packages used

- `Microsoft.CodeCoverage`
- `Microsoft.NET.Test.Sdk`
- `NUnit`
- `NUnit3TestAdapter`
- `Selenium.WebDriver`
- `Selenium.WebDriver.ChromeDriver`
- `Selenium.Support`
- `DotNetSeleniumExtras.WaitHelpers`

### Site used for testing
[mathscientific.com/lt](https://mathscientific.com/lt/)

## Tests used for pages testing

### 1. Open Menu page
- Open https://mathscientific.com/lt/
- Hover mouse on "Meniu"
- Check if in "Meniu" content are category "Mokslas"

### 2. Change language from LT to International
- Open https://mathscientific.com/lt/
- Hover mouse on language symbol
- Click to choose International language
- Check if "Prisijungti" changed to "Login"

### 3. Create account with existing credentials 
- Open https://mathscientific.com/lt/
- Navigate to Login page
- Enter Email
- Enter Password
- Click on "Registruotis"
- Check if displayed message: "Klaida: Paskyra su tokiu el.pašto adresu jau yra sukurta. Prisijunkite."

### 4. Login with existing credentials 
- Open https://mathscientific.com/lt/
- Navigate to Login page
- Enter Email
- Enter Password
- Click on "Prisijungti"
- Check if "Mano paskyra" function appeared

### 5. Add one porduct: Kolagenas Su Avietemis to the shopping card
- Open https://mathscientific.com/lt/
- Hover mouse on "Meniu"
- Cklick on "Maisto Papildai"
- Click on "Kolagenas su Avietėmis"
- Add product to the shopping card
- Check if displayed message: "Produktas sėkmingai įdėtas į krepšelį."

### 6. Join to subscribers Club
'Prisijungti prie prenumeratoriu, langas atsidaro kazkur po 20 sec'
- Open https://mathscientific.com/lt/
- Enter e-mail
- Enter name
- Click on Skin Type
- Click on skin type "Normali"
- Click button "Prenumeruoti Naujinelaiškį"
- Check if displayed message: "Dėkojame, kad prenumeruojate mūsų naujienas!"
- Close subscriber window

`Testas kartais(daznai) atidaro puslapi anglu kalba, ir tuomet visi testai nuluzta, kol kas nepavyko issiaiskinti kodel`
`Jei taip nutinka, tuomet i [Setup] galim iskelti du pirmus zingsnius is testo 'switchLanguageFromLtToEn' ir paleisti testus`