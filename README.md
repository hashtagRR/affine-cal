# affine-cal

A small Windows Forms desktop utility for encoding and decoding text with the
[affine cipher](https://en.wikipedia.org/wiki/Affine_cipher), a monoalphabetic
substitution cipher of the form `e(x) = (a*x + b) mod 26`. Written in C#
(.NET Framework 4.6.1).

This is a coursework/learning project, not production software.

## Features

- **Encode**: type plain text and pick key values `a` (k1) and `b` (k2) from
  dropdowns; the form computes `e(x) = (a*x + b) mod 26` for each letter
  (input is upper-cased, non-letter characters are not filtered out before
  the shift is applied).
- **Decode**: type cipher text and the same key pair; the form computes the
  multiplicative inverse of `a` mod 26 and applies
  `d(x) = a⁻¹ * (e(x) - b) mod 26` to recover the plain text.
- Encoding and decoding are independent panels with their own inputs — it is
  not a live two-way transform of a single text box.

## Project layout

- `Affine_cipher.sln` — Visual Studio solution.
- `Affine_cipher/Affine.cs` — the form and the cipher math
  (`button1_Click` for encode, `button3_Click` for decode,
  `MultiplicativeInverse` helper).
- `Affine_cipher/Affine.Designer.cs`, `Affine_cipher/Affine.resx` — the
  generated WinForms UI.

## Running it

1. Open `Affine_cipher.sln` in Visual Studio (2017 or later works fine;
   targets .NET Framework 4.6.1).
2. Build and run (F5). No external dependencies or database are needed.
3. Alternatively, build from the command line with MSBuild:
   `msbuild Affine_cipher.sln` and run the resulting `.exe` from `bin\Debug`.

Note: only valid key pairs (where `a` has a multiplicative inverse mod 26,
i.e. `a` is coprime with 26) will decode correctly; the app does not
validate this and will throw if an invalid key is used for decoding.
