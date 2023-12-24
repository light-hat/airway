<div align="center">
<h1>Airway</h1>

Simpe network sniffer written on C#.

[![Build and Deploy](https://github.com/light-hat/airway/actions/workflows/any.yml/badge.svg)](https://github.com/light-hat/airway/actions/workflows/any.yml/badge.svg)
[![Build and Deploy](https://github.com/light-hat/airway/actions/workflows/release.yml/badge.svg)](https://github.com/light-hat/airway/actions/workflows/release.yml/badge.svg)
[![GitHub release](https://img.shields.io/github/v/release/light-hat/airway.svg)](https://GitHub.com/light-hat/airway/releases/)
[![GitHub issues](https://img.shields.io/github/issues/light-hat/airway.svg)](https://GitHub.com/light-hat/airway/issues/)

</div>

## Features

- Basic interface
- Determining Available Network Interfaces

## Autorelease

Write your changelog for new version in [Release.md](Release.md) file.

Send commit as release:

```powershell
.\autorelease.ps1 "update: your message"
```

Update a minor version:

```powershell
.\autorelease.ps1 "update: your message" -set_minor
```

Before: `0.0.1`;
After:  `0.1.0`

Update a major version:

```powershell
.\autorelease.ps1 "update: your message" -set_major
```

Before: `0.1.1`;
After:  `1.0.0`

Make commit without tag and release:

```powershell
.\autocommit.ps1 "update: your message"
```

## Licensing

Airway is licensed under the [MIT License](https://github.com/light-hat/airway/blob/master/LICENSE).

