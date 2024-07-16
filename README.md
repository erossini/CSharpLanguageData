# Language Data Library for C#

This library is a comprehensive language code information, consisting of ISO 639-1, ISO 639-2 and IETF language types for C#.

## Install Library

To install the library in your project, open the *Package Manager* and type the following command:

```cSharp
Install-Package PSC.CSharp.Library.LanguageData
```

Also, you can use the .NET CLI to install the library. Type the following command:

```cSharp
dotnet add package PSC.CSharp.Library.LanguageData
```

## Usage

Here is an example how to use the library in your project.

### Initialize the LanguageData

```cSharp
using PSC.CSharp.Library.LanguageData;

// loads all Language Data via the constructor (You can initialize this once as a singleton)
var languageHelper = new LanguageHelper();
```

### Function

| **Function**         | **Return** | **Description**                                                |
|----------------------|------------|----------------------------------------------------------------|
| GetLanguage          | Language?  | Return all the details for a specific language                 |
| GetLanguageCode6392B | string?    | Return the value of ISO 639-2 B for a specific code language   |
| GetLanguageCode6392T | string?    | Return the value of ISO 639-2 T for a specific code language   |
| GetLanguageDirection | string?    | Return the direction for a specific code language (ltr or rtl) |
| GetLanguageName      | string?    | Return the language name for a specific code language          |
| GetLanguageNative    | string?    | Return the native language name for a specific code language   |
| GetLanguages         | string?    | Return the full list of languages with all the details         |
| GetLanguageScript    | string?    | Return the script type for a specific code language (ie. Latn) |

## Data

Data is taken from the [Library of Congress](http://www.loc.gov/standards/iso639-2/iso639-2ra.html) as the ISO 639-2 Registration Authority, and from the [Unicode Common Locale Data Repository](http://cldr.unicode.org/).

### Columns

- **ShortCode** is _ISO 639-1_ (alpha 2 / two letter)
- **Code6392T** is _ISO 639-2_ (alpha 3 / three letter) bibliographic codes and ISO 639-1 codes
- **Code6392B** is _ISO 639-2_ (alpha 3 / three letter) bibliographic codes and ISO 639-1 codes
- **LanguageName** is the name of the language in English
- **LanguageNative** is the name of the language in its native language
- **Direction** is the direction of the language (ltr or rtl)
- **Script** is the type of script of the language if it is known

### Code explanation

There are two versions of the three letter codes: bibliographic and terminologic. Each language has a bibliographic code but only a few languages have terminologic codes. Terminologic codes are chosen to be similar to the corresponding ISO 639-1 two letter codes.

Example from [Wikipedia](https://en.wikipedia.org/wiki/ISO_639#Relations_between_the_parts):
> [...] the German language (Part 1: `de`) has two codes in Part 2: `ger` (T code) and `deu` (B code), whereas there is only one code in Part 2, `eng`, for the English language.

There are four special codes: *mul*, *und*, *mis*, *zxx*; and a reserved range *qaa-qtz*.

## Language table

| **ShortCode** | **Code (639-2 B)** | **Code6392B (639-2 T)** | **LanguageName**                                    | **LanguageNative**                                        | **Direction** | **Script** |
|---------------|--------------------|-------------------------|-----------------------------------------------------|-----------------------------------------------------------|---------------|------------|
| aa            | aar                | aar                     | Afar                                                | Afaraf                                                    | ltr           |            |
| ab            | abk                | abk                     | Abkhaz                                              | аҧсуа бызшәа, аҧсшәа                                      | ltr           | Cyrl       |
| ae            | ave                | ave                     | Avestan                                             | avesta                                                    |               |            |
| af            | afr                | afr                     | Afrikaans                                           | Afrikaans                                                 | ltr           | Latn       |
| ak            | aka                | aka                     | Akan                                                | Akan                                                      | ltr           |            |
| am            | amh                | amh                     | Amharic                                             | አማርኛ                                                      | ltr           | Ethi       |
| an            | arg                | arg                     | Aragonese                                           | aragonés                                                  | ltr           |            |
| ar            | ara                | ara                     | Arabic                                              | العربية                                                   | rtl           | Arab       |
| as            | asm                | asm                     | Assamese                                            | অসমীয়া                                                   | ltr           | Beng       |
| av            | ava                | ava                     | Avaric                                              | авар мацӀ, магӀарул мацӀ                                  | ltr           |            |
| ay            | aym                | aym                     | Aymara                                              | aymar aru                                                 | ltr           | Latn       |
| az            | aze                | aze                     | Azerbaijani                                         | azərbaycan dili                                           | ltr           |            |
| az            | azb                | azb                     | South Azerbaijani                                   | تورکجه‎                                                   | ltr           |            |
| ba            | bak                | bak                     | Bashkir                                             | башҡорт теле                                              | ltr           |            |
| be            | bel                | bel                     | Belarusian                                          | беларуская мова                                           | ltr           | Cyrl       |
| bg            | bul                | bul                     | Bulgarian                                           | български език                                            | ltr           | Cyrl       |
| bh            | bih                | bih                     | Bihari                                              | भोजपुरी                                                   | ltr           |            |
| bi            | bis                | bis                     | Bislama                                             | Bislama                                                   | ltr           |            |
| bm            | bam                | bam                     | Bambara                                             | bamanankan                                                | ltr           |            |
| bn            | ben                | ben                     | Bengali; Bangla                                     | বাংলা                                                     | ltr           | Beng       |
| bo            | bod                | tib                     | Tibetan Standard, Tibetan, Central                  | བོད་ཡིག                                                   | ltr           |            |
| br            | bre                | bre                     | Breton                                              | brezhoneg                                                 | ltr           |            |
| bs            | bos                | bos                     | Bosnian                                             | bosanski jezik                                            | ltr           | Latn       |
| ca            | cat                | cat                     | Catalan; Valencian                                  | català, valencià                                          | ltr           | Latn       |
| ce            | che                | che                     | Chechen                                             | нохчийн мотт                                              | ltr           |            |
| ch            | cha                | cha                     | Chamorro                                            | Chamoru                                                   | ltr           | Latn       |
| co            | cos                | cos                     | Corsican                                            | corsu, lingua corsa                                       | ltr           |            |
| cr            | cre                | cre                     | Cree                                                | ᓀᐦᐃᔭᐍᐏᐣ                                                   | ltr           |            |
| cs            | ces                | cze                     | Czech                                               | čeština, český jazyk                                      | ltr           | Latn       |
| cu            | chu                | chu                     | Old Church Slavonic, Church Slavonic, Old Bulgarian | ѩзыкъ словѣньскъ                                          | ltr           |            |
| cv            | chv                | chv                     | Chuvash                                             | чӑваш чӗлхи                                               | ltr           |            |
| cy            | cym                | wel                     | Welsh                                               | Cymraeg                                                   | ltr           | Latn       |
| da            | dan                | dan                     | Danish                                              | dansk                                                     | ltr           | Latn       |
| de            | deu                | ger                     | German                                              | Deutsch                                                   | ltr           | Latn       |
| dv            | div                | div                     | Divehi; Dhivehi; Maldivian;                         | ދިވެހި                                                    | rtl           | Thaa       |
| dz            | dzo                | dzo                     | Dzongkha                                            | རྫོང་ཁ                                                    | ltr           | Tibt       |
| ee            | ewe                | ewe                     | Ewe                                                 | Eʋegbe                                                    | ltr           |            |
| el            | ell                | gre                     | Greek, Modern                                       | ελληνικά                                                  | ltr           | Grek       |
| en            | eng                | eng                     | English                                             | English                                                   | ltr           | Latn       |
| eo            | epo                | epo                     | Esperanto                                           | Esperanto                                                 | ltr           | Latn       |
| es            | spa                | spa                     | Spanish; Castilian                                  | español, castellano                                       | ltr           | Latn       |
| et            | est                | est                     | Estonian                                            | eesti, eesti keel                                         | ltr           | Latn       |
| eu            | eus                | baq                     | Basque                                              | euskara, euskera                                          | ltr           | Latn       |
| fa            | fas                | per                     | Persian (Farsi)                                     | فارسی                                                     | rtl           | Arab       |
| ff            | ful                | ful                     | Fula; Fulah; Pulaar; Pular                          | Fulfulde, Pulaar, Pular                                   | ltr           |            |
| fi            | fin                | fin                     | Finnish                                             | suomi, suomen kieli                                       | ltr           | Latn       |
| fj            | fij                | fij                     | Fijian                                              | vosa Vakaviti                                             | ltr           | Latn       |
| fo            | fao                | fao                     | Faroese                                             | føroyskt                                                  | ltr           | Latn       |
| fr            | fra                | fre                     | French                                              | français, langue française                                | ltr           | Latn       |
| fy            | fry                | fry                     | Western Frisian                                     | Frysk                                                     | ltr           | Latn       |
| ga            | gle                | gle                     | Irish                                               | Gaeilge                                                   | ltr           | Latn       |
| gd            | gla                | gla                     | Scottish Gaelic; Gaelic                             | Gàidhlig                                                  | ltr           |            |
| gl            | glg                | glg                     | Galician                                            | galego                                                    | ltr           | Latn       |
| gn            | grn                | grn                     | Guaraní                                             | Avañe'ẽ                                                   | ltr           | Latn       |
| gu            | guj                | guj                     | Gujarati                                            | ગુજરાતી                                                   | ltr           | Gujr       |
| gv            | glv                | glv                     | Manx                                                | Gaelg, Gailck                                             | ltr           | Latn       |
| ha            | hau                | hau                     | Hausa                                               | Hausa, هَوُسَ                                             | rtl           |            |
| he            | heb                | heb                     | Hebrew (modern)                                     | עברית                                                     | rtl           | Hebr       |
| hi            | hin                | hin                     | Hindi                                               | हिन्दी, हिंदी                                             | ltr           | Deva       |
| ho            | hmo                | hmo                     | Hiri Motu                                           | Hiri Motu                                                 | ltr           |            |
| hr            | hrv                | hrv                     | Croatian                                            | hrvatski jezik                                            | ltr           | Latn       |
| ht            | hat                | hat                     | Haitian; Haitian Creole                             | Kreyòl ayisyen                                            | ltr           | Latn       |
| hu            | hun                | hun                     | Hungarian                                           | magyar                                                    | ltr           | Latn       |
| hy            | hye                | arm                     | Armenian                                            | Հայերեն                                                   | ltr           | Armn       |
| hz            | her                | her                     | Herero                                              | Otjiherero                                                | ltr           |            |
| ia            | ina                | ina                     | Interlingua                                         | Interlingua                                               | ltr           |            |
| id            | ind                | ind                     | Indonesian                                          | Bahasa Indonesia                                          | ltr           | Latn       |
| ie            | ile                | ile                     | Interlingue                                         | Originally called Occidental; then Interlingue after WWII | ltr           |            |
| ig            | ibo                | ibo                     | Igbo                                                | Asụsụ Igbo                                                | ltr           |            |
| ii            | iii                | iii                     | Nuosu                                               | ꆈꌠ꒿ Nuosuhxop                                             | ltr           |            |
| ik            | ipk                | ipk                     | Inupiaq                                             | Iñupiaq, Iñupiatun                                        | ltr           |            |
| io            | ido                | ido                     | Ido                                                 | Ido                                                       | ltr           |            |
| is            | isl                | ice                     | Icelandic                                           | Íslenska                                                  | ltr           | Latn       |
| it            | ita                | ita                     | Italian                                             | italiano                                                  | ltr           | Latn       |
| iu            | iku                | iku                     | Inuktitut                                           | ᐃᓄᒃᑎᑐᑦ                                                    | ltr           |            |
| ja            | jpn                | jpn                     | Japanese                                            | 日本語 (にほんご)                                                | ltr           | Jpan       |
| jv            | jav                | jav                     | Javanese                                            | basa Jawa                                                 | ltr           |            |
| ka            | kat                | geo                     | Georgian                                            | ქართული                                                   | ltr           | Geor       |
| kg            | kon                | kon                     | Kongo                                               | KiKongo                                                   | ltr           |            |
| ki            | kik                | kik                     | Kikuyu, Gikuyu                                      | Gĩkũyũ                                                    | ltr           |            |
| kj            | kua                | kua                     | Kwanyama, Kuanyama                                  | Kuanyama                                                  | ltr           |            |
| kk            | kaz                | kaz                     | Kazakh                                              | қазақ тілі                                                | ltr           | Cyrl       |
| kl            | kal                | kal                     | Kalaallisut, Greenlandic                            | kalaallisut, kalaallit oqaasii                            | ltr           | Latn       |
| km            | khm                | khm                     | Khmer                                               | ខ្មែរ, ខេមរភាសា, ភាសាខ្មែរ                                | ltr           | Khmr       |
| kn            | kan                | kan                     | Kannada                                             | ಕನ್ನಡ                                                     | ltr           | Knda       |
| ko            | kor                | kor                     | Korean                                              | 한국어 (韓國語), 조선어 (朝鮮語)                                      | ltr           | Kore       |
| kr            | kau                | kau                     | Kanuri                                              | Kanuri                                                    | ltr           |            |
| ks            | kas                | kas                     | Kashmiri                                            | कश्मीरी, كشميري‎                                          | rtl           |            |
| ku            | kur                | kur                     | Kurdish                                             | Kurdî, كوردی‎                                             | rtl           |            |
| kv            | kom                | kom                     | Komi                                                | коми кыв                                                  | ltr           |            |
| kw            | cor                | cor                     | Cornish                                             | Kernewek                                                  | ltr           |            |
| ky            | kir                | kir                     | Kyrgyz                                              | Кыргызча, Кыргыз тили                                     | ltr           |            |
| la            | lat                | lat                     | Latin                                               | latine, lingua latina                                     | ltr           | Latn       |
| lb            | ltz                | ltz                     | Luxembourgish, Letzeburgesch                        | Lëtzebuergesch                                            | ltr           | Latn       |
| lg            | lug                | lug                     | Ganda                                               | Luganda                                                   | ltr           |            |
| li            | lim                | lim                     | Limburgish, Limburgan, Limburger                    | Limburgs                                                  | ltr           |            |
| ln            | lin                | lin                     | Lingala                                             | Lingála                                                   | ltr           | Latn       |
| lo            | lao                | lao                     | Lao                                                 | ພາສາລາວ                                                   | ltr           | Laoo       |
| lt            | lit                | lit                     | Lithuanian                                          | lietuvių kalba                                            | ltr           | Latn       |
| lu            | lub                | lub                     | Luba-Katanga                                        | Tshiluba                                                  |               |            |
| lv            | lav                | lav                     | Latvian                                             | latviešu valoda                                           | ltr           | Latn       |
| mg            | mlg                | mlg                     | Malagasy                                            | fiteny malagasy                                           | ltr           | Latn       |
| mh            | mah                | mah                     | Marshallese                                         | Kajin M̧ajeļ                                              | ltr           | Latn       |
| mi            | mri                | mao                     | Māori                                               | te reo Māori                                              | ltr           |            |
| mk            | mkd                | mac                     | Macedonian                                          | македонски јазик                                          | ltr           | Cyrl       |
| ml            | mal                | mal                     | Malayalam                                           | മലയാളം                                                    | ltr           | Mlym       |
| mn            | mon                | mon                     | Mongolian                                           | монгол                                                    | ltr           |            |
| mr            | mar                | mar                     | Marathi (Marāṭhī)                                   | मराठी                                                     | ltr           | Deva       |
| ms            | msa                | may                     | Malay                                               | bahasa Melayu, بهاس ملايو‎                                | ltr           | Latn       |
| mt            | mlt                | mlt                     | Maltese                                             | Malti                                                     | ltr           | Latn       |
| my            | mya                | bur                     | Burmese                                             | ဗမာစာ                                                     | ltr           | Mymr       |
| na            | nau                | nau                     | Nauru                                               | Ekakairũ Naoero                                           | ltr           | Latn       |
| nb            | nob                | nob                     | Norwegian Bokmål                                    | Norsk bokmål                                              | ltr           | Latn       |
| nd            | nde                | nde                     | North Ndebele                                       | isiNdebele                                                | ltr           | Latn       |
| ne            | nep                | nep                     | Nepali                                              | नेपाली                                                    | ltr           | Deva       |
| ng            | ndo                | ndo                     | Ndonga                                              | Owambo                                                    | ltr           |            |
| nl            | nld                | dut                     | Dutch                                               | Nederlands, Vlaams                                        | ltr           | Latn       |
| nn            | nno                | nno                     | Norwegian Nynorsk                                   | Norsk nynorsk                                             | ltr           | Latn       |
| no            | nor                | nor                     | Norwegian                                           | Norsk                                                     | ltr           | Latn       |
| nr            | nbl                | nbl                     | South Ndebele                                       | isiNdebele                                                | ltr           | Latn       |
| nv            | nav                | nav                     | Navajo, Navaho                                      | Diné bizaad, Dinékʼehǰí                                   | ltr           |            |
| ny            | nya                | nya                     | Chichewa; Chewa; Nyanja                             | chiCheŵa, chinyanja                                       | ltr           | Latn       |
| oc            | oci                | oci                     | Occitan                                             | occitan, lenga d'òc                                       | ltr           |            |
| oj            | oji                | oji                     | Ojibwe, Ojibwa                                      | ᐊᓂᔑᓈᐯᒧᐎᓐ                                                  | ltr           |            |
| om            | orm                | orm                     | Oromo                                               | Afaan Oromoo                                              | ltr           | Latn       |
| or            | ori                | ori                     | Oriya                                               | ଓଡ଼ିଆ                                                     | ltr           | Orya       |
| os            | oss                | oss                     | Ossetian, Ossetic                                   | ирон æвзаг                                                | ltr           |            |
| pa            | pan                | pan                     | Panjabi, Punjabi                                    | ਪੰਜਾਬੀ, پنجابی‎                                           | ltr           | Guru       |
| pi            | pli                | pli                     | Pāli                                                | पाऴि                                                      | ltr           |            |
| pl            | pol                | pol                     | Polish                                              | język polski, polszczyzna                                 | ltr           | Latn       |
| ps            | pus                | pus                     | Pashto, Pushto                                      | پښتو                                                      | rtl           | Arab       |
| pt            | por                | por                     | Portuguese                                          | português                                                 | ltr           | Latn       |
| qu            | que                | que                     | Quechua                                             | Runa Simi, Kichwa                                         | ltr           | Latn       |
| rm            | roh                | roh                     | Romansh                                             | rumantsch grischun                                        | ltr           | Latn       |
| rn            | run                | run                     | Kirundi                                             | Ikirundi                                                  | ltr           | Latn       |
| ro            | ron                | rum                     | Romanian                                            | limba română                                              | ltr           | Latn       |
| ru            | rus                | rus                     | Russian                                             | русский язык                                              | ltr           | Cyrl       |
| rw            | kin                | kin                     | Kinyarwanda                                         | Ikinyarwanda                                              | ltr           | Latn       |
| sa            | san                | san                     | Sanskrit (Saṁskṛta)                                 | संस्कृतम्                                                 | ltr           |            |
| sc            | srd                | srd                     | Sardinian                                           | sardu                                                     | ltr           |            |
| sd            | snd                | snd                     | Sindhi                                              | सिन्धी, سنڌي، سندھی‎                                      | ltr           |            |
| se            | sme                | sme                     | Northern Sami                                       | Davvisámegiella                                           | ltr           |            |
| sg            | sag                | sag                     | Sango                                               | yângâ tî sängö                                            | ltr           | Latn       |
| si            | sin                | sin                     | Sinhala, Sinhalese                                  | සිංහල                                                     | ltr           | Sinh       |
| sk            | slk                | slo                     | Slovak                                              | slovenčina, slovenský jazyk                               | ltr           | Latn       |
| sl            | slv                | slv                     | Slovene                                             | slovenski jezik, slovenščina                              | ltr           | Latn       |
| sm            | smo                | smo                     | Samoan                                              | gagana fa'a Samoa                                         | ltr           | Latn       |
| sn            | sna                | sna                     | Shona                                               | chiShona                                                  | ltr           |            |
| so            | som                | som                     | Somali                                              | Soomaaliga, af Soomaali                                   | ltr           | Latn       |
| sq            | sqi                | alb                     | Albanian                                            | gjuha shqipe                                              | ltr           | Latn       |
| sr            | srp                | srp                     | Serbian                                             | српски језик                                              | ltr           |            |
| ss            | ssw                | ssw                     | Swati                                               | SiSwati                                                   | ltr           | Latn       |
| st            | sot                | sot                     | Southern Sotho                                      | Sesotho                                                   | ltr           | Latn       |
| su            | sun                | sun                     | Sundanese                                           | Basa Sunda                                                | ltr           |            |
| sv            | swe                | swe                     | Swedish                                             | Svenska                                                   | ltr           | Latn       |
| sw            | swa                | swa                     | Swahili                                             | Kiswahili                                                 | ltr           | Latn       |
| ta            | tam                | tam                     | Tamil                                               | தமிழ்                                                     | ltr           | Taml       |
| te            | tel                | tel                     | Telugu                                              | తెలుగు                                                    | ltr           | Telu       |
| tg            | tgk                | tgk                     | Tajik                                               | тоҷикӣ, toğikī, تاجیکی‎                                   | ltr           |            |
| th            | tha                | tha                     | Thai                                                | ไทย                                                       | ltr           | Thai       |
| ti            | tir                | tir                     | Tigrinya                                            | ትግርኛ                                                      | ltr           | Ethi       |
| tk            | tuk                | tuk                     | Turkmen                                             | Türkmen, Түркмен                                          | ltr           |            |
| tl            | tgl                | tgl                     | Tagalog                                             | Wikang Tagalog, ᜏᜒᜃᜅ᜔ ᜆᜄᜎᜓᜄ᜔                              | ltr           | Latn       |
| tn            | tsn                | tsn                     | Tswana                                              | Setswana                                                  | ltr           | Latn       |
| to            | ton                | ton                     | Tonga (Tonga Islands)                               | faka Tonga                                                | ltr           | Latn       |
| tr            | tur                | tur                     | Turkish                                             | Türkçe                                                    | ltr           | Latn       |
| ts            | tso                | tso                     | Tsonga                                              | Xitsonga                                                  | ltr           | Latn       |
| tt            | tat                | tat                     | Tatar                                               | татар теле, tatar tele                                    | ltr           |            |
| tw            | twi                | twi                     | Twi                                                 | Twi                                                       | ltr           |            |
| ty            | tah                | tah                     | Tahitian                                            | Reo Tahiti                                                | ltr           |            |
| ug            | uig                | uig                     | Uyghur, Uighur                                      | Uyƣurqə, ئۇيغۇرچە‎                                        | ltr           |            |
| uk            | ukr                | ukr                     | Ukrainian                                           | українська мова                                           | ltr           | Cyrl       |
| ur            | urd                | urd                     | Urdu                                                | اردو                                                      | rtl           | Arab       |
| uz            | uzb                | uzb                     | Uzbek                                               | O‘zbek, Ўзбек, أۇزبېك‎                                    | ltr           |            |
| ve            | ven                | ven                     | Venda                                               | Tshivenḓa                                                 | ltr           | Latn       |
| vi            | vie                | vie                     | Vietnamese                                          | Tiếng Việt                                                | ltr           | Latn       |
| vo            | vol                | vol                     | Volapük                                             | Volapük                                                   | ltr           |            |
| wa            | wln                | wln                     | Walloon                                             | walon                                                     | ltr           |            |
| wo            | wol                | wol                     | Wolof                                               | Wollof                                                    | ltr           |            |
| xh            | xho                | xho                     | Xhosa                                               | isiXhosa                                                  | ltr           | Latn       |
| yi            | yid                | yid                     | Yiddish                                             | ייִדיש                                                    | rtl           | Hebr       |
| yo            | yor                | yor                     | Yoruba                                              | Yorùbá                                                    | ltr           |            |
| za            | zha                | zha                     | Zhuang, Chuang                                      | Saɯ cueŋƅ, Saw cuengh                                     | ltr           |            |
| zh            | zho                | chi                     | Chinese                                             | 中文 (Zhōngwén), 汉语, 漢語                                     | ltr           |            |
| zu            | zul                | zul                     | Zulu                                                | isiZulu                                                   | ltr           | Latn       |

---
    
## PureSourceCode.com

[PureSourceCode.com](https://www.puresourcecode.com/) is my personal blog where I publish posts about technologies and in particular source code and projects in [.NET](https://www.puresourcecode.com/category/dotnet/). 

In the last few months, I created a lot of components for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/).

My name is Enrico Rossini and you can contact me via:
- [Personal Twitter](https://twitter.com/erossiniuk)
- [LinkedIn](https://www.linkedin.com/in/rossiniuk)
- [Facebook](https://www.facebook.com/puresourcecode)

## Blazor Components

| Component name | Forum | NuGet | Website | Description |
|---|---|---|---|---|
| [AnchorLink]() | [Forum](https://puresourcecode.com/forum/anchorlink/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.AnchorLink) | | An anchor link is a web link that allows users to leapfrog to a specific point on a website page. It saves them the need to scroll and skim read and makes navigation easier. This component is for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Autocomplete for Blazor](https://www.puresourcecode.com/dotnet/net-core/autocomplete-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/autocomplete-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Autocomplete) | | Simple and flexible autocomplete type-ahead functionality for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Browser Detect for Blazor](https://www.puresourcecode.com/dotnet/blazor/browser-detect-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/browser-detect-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.BrowserDetect) | [Demo](https://browserdetect.puresourcecode.com) | Browser detect for Blazor WebAssembly and Blazor Server |
| [ChartJs for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/chart-js-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Chartjs) | [Demo](https://chartjs.puresourcecode.com/) | Add beautiful graphs based on ChartJs in your Blazor application |
| [Clippy for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/) | [Forum](https://www.puresourcecode.com/forum/clippy/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Clippy) | [Demo](https://clippy.puresourcecode.com/) | Do you miss Clippy? Here the implementation for Blazor |
| [CodeSnipper for Blazor](https://www.puresourcecode.com/dotnet/blazor/code-snippet-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/codesnippet-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CodeSnippet) | | Add code snippet in your Blazor pages for 196 programming languages with 243 styles |
| [Copy To Clipboard](https://www.puresourcecode.com/dotnet/blazor/copy-to-clipboard-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/copytoclipboard/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.CopyToClipboard) | | Add a button to copy text in the clipboard | 
| [DataTable for Blazor](https://www.puresourcecode.com/dotnet/net-core/datatable-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/datatables/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.DataTable) | [Demo](https://datatable.puresourcecode.com/) | DataTable component for Blazor WebAssembly and Blazor Server |
| [Google Tag Manager]() | [Forum]() | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.GoogleTagManager) | [Demo](https://datatable.puresourcecode.com/) | Adds Google Tag Manager to the application and manages communication with GTM JavaScript (data layer). |
| [Icons and flags for Blazor](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/icons-and-flags-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Icons) | | Library with a lot of SVG icons and SVG flags to use in your Razor pages |
| [ImageSelect for Blazor]() | [Forum](https://puresourcecode.com/forum/imageselect/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ImageSelect) | | This is a Blazor component to display a dropdown list with images based on ms-Dropdown by Marghoob Suleman. This component is built with NET7 for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/) |
| [Markdown editor for Blazor](https://www.puresourcecode.com/dotnet/blazor/markdown-editor-with-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/markdown-editor-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.MarkdownEditor) | [Demo](https://markdown.puresourcecode.com/) | This is a Markdown Editor for use in Blazor. It contains a live preview as well as an embeded help guide for users. |
| [Modal dialog for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ModalDialog) | | Simple Modal Dialog for Blazor WebAssembly |
| [Modal windows for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/modal-dialog-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Modals) | | Modal Windows for Blazor WebAssembly |
| [Quill for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-a-blazor-component-for-quill/) | [Forum](https://www.puresourcecode.com/forum/forum/quill-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Quill) | | Quill Component is a custom reusable control that allows us to easily consume Quill and place multiple instances of it on a single page in our Blazor application |
| [ScrollTabs](https://www.puresourcecode.com/dotnet/blazor/scrolltabs-component-for-blazor/) | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.ScrollTabs) | | Tabs with nice scroll (no scrollbar) and responsive |
| [Segment for Blazor](https://www.puresourcecode.com/dotnet/blazor/segment-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/segments-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Segments) | | This is a Segment component for Blazor Web Assembly and Blazor Server |
| [Tabs for Blazor](https://www.puresourcecode.com/dotnet/blazor/tabs-control-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/forum/tabs-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tabs) | | This is a Tabs component for Blazor Web Assembly and Blazor Server |
| [Timeline for Blazor](https://www.puresourcecode.com/dotnet/blazor/timeline-component-for-blazor/) | [Forum](https://www.puresourcecode.com/forum/timeline/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Timeline) | | This is a new responsive timeline  for Blazor Web Assembly and Blazor Server |
| [Toast for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Toast) | | Toast notification for Blazor applications |
| [Tours for Blazor](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.Tours) | | Guide your users in your Blazor applications |
| [TreeView for Blazor]() | [Forum](https://puresourcecode.com/forum/treeview/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.TreeView) | | This component is a native Blazor TreeView component for [Blazor WebAssembly](https://www.puresourcecode.com/tag/blazor-webassembly/) and [Blazor Server](https://www.puresourcecode.com/tag/blazor-server/). The component is built with .NET7. |
| [WorldMap for Blazor](https://puresourcecode.com/dotnet/blazor/world-map-component-for-blazor) | [Forum](https://www.puresourcecode.com/forum/worldmap-for-blazor/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Blazor.Components.WorldMap) | [Demo](https://worldmap.puresourcecode.com/) | Show world maps with your data |

## C# libraries for .NET6

| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.Evaluator](https://www.puresourcecode.com/forum/psc-components-and-source-code/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Evaluator) | PSC.Evaluator is a mathematical expressions evaluator library written in C#. Allows to evaluate mathematical, boolean, string and datetime expressions. |
| [PSC.Extensions](https://www.puresourcecode.com/dotnet/net-core/a-lot-of-functions-for-net5/) | [Forum](https://www.puresourcecode.com/forum/forum/psc-extensions/) | ![NuGet badge](https://img.shields.io/nuget/v/PSC.Extensions) | A lot of functions for .NET5 in a NuGet package that you can download for free. We collected in this package functions for everyday work to help you with claim, strings, enums, date and time, expressions... |

## C# libraries for .NET8
| Component name | Forum | NuGet | Description |
|---|---|---|---|
| [PSC.CSharp.Library.CountryData](https://puresourcecode.com/dotnet/net8/country-data-library-for-net8/) | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.CSharp.Library.CountryData) | A simple cross platform offline .NET library for getting country data. |
| PSC.CSharp.Library.LanguageData | | ![NuGet badge](https://img.shields.io/nuget/v/PSC.CSharp.Library.LanguageData) | This library is a comprehensive language code information, consisting of ISO 639-1, ISO 639-2 and IETF language types for C#. |

## More examples and documentation

### Blazor
*   [Write a reusable Blazor component](https://www.puresourcecode.com/dotnet/blazor/write-a-reusable-blazor-component/)
*   [Getting Started With C# And Blazor](https://www.puresourcecode.com/dotnet/net-core/getting-started-with-c-and-blazor/)
*   [Setting Up A Blazor WebAssembly Application](https://www.puresourcecode.com/dotnet/blazor/setting-up-a-blazor-webassembly-application/)
*   [Working With Blazor Component Model](https://www.puresourcecode.com/dotnet/blazor/working-with-blazors-component-model/)
*   [Secure Blazor WebAssembly With IdentityServer4](https://www.puresourcecode.com/dotnet/blazor/secure-blazor-webassembly-with-identityserver4/)
*   [Blazor Using HttpClient With Authentication](https://www.puresourcecode.com/dotnet/blazor/blazor-using-httpclient-with-authentication/)
*   [InputSelect component for enumerations in Blazor](https://www.puresourcecode.com/dotnet/blazor/inputselect-component-for-enumerations-in-blazor/)
*   [Use LocalStorage with Blazor WebAssembly](https://www.puresourcecode.com/dotnet/blazor/use-localstorage-with-blazor-webassembly/)
*   [Modal Dialog component for Blazor](https://www.puresourcecode.com/dotnet/blazor/modal-dialog-component-for-blazor/)
*   [Create Tooltip component for Blazor](https://www.puresourcecode.com/dotnet/blazor/create-tooltip-component-for-blazor/)
*   [Consume ASP.NET Core Razor components from Razor class libraries | Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/class-libraries?view=aspnetcore-5.0&tabs=visual-studio)
*   [ChartJs component for Blazor](https://www.puresourcecode.com/dotnet/blazor/blazor-component-for-chartjs/)
*   [Labels and OnClickChart for ChartJs](https://www.puresourcecode.com/dotnet/blazor/labels-and-onclickchart-for-chartjs/)

### Blazor & NET8
* [Custom User Management with NET8 and Blazor (1st part)](https://puresourcecode.com/dotnet/blazor/custom-user-management-with-net8-and-blazor/)
* [NET8, Blazor and Custom User Management (2nd part)](https://puresourcecode.com/dotnet/blazor/net8-blazor-and-custom-user-management/)
