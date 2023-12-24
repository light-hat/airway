<div align="center">
<h1>Airway</h1>

Simpe network sniffer written on C#.

[![Build and Deploy](https://github.com/light-hat/airway/actions/workflows/any.yml/badge.svg)](https://github.com/light-hat/airway/actions/workflows/any.yml/)
[![Build and Deploy](https://github.com/light-hat/airway/actions/workflows/release.yml/badge.svg)](https://github.com/light-hat/airway/actions/workflows/release.yml/)
[![GitHub release](https://img.shields.io/github/v/release/light-hat/airway.svg)](https://GitHub.com/light-hat/airway/releases/)

</div>

# TODO

Конечно существует библиотека SharpPcap, которая умеет снимать траффик с сетевого интерфейса, но это не интересно =)
Дальнейшая задача - реализовать функционал перевода выбранной сетевой карты в режим мониторинга, чтения с неё траффика
Дальше надо реализовать как в Wireshark инкапсуляцию пакетов

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

Result: `0.0.1` -> `0.1.0`

Update a major version:

```powershell
.\autorelease.ps1 "update: your message" -set_major
```

Result: `0.1.1` -> `1.0.0`

To make commit `without` tag and release:

```powershell
.\autocommit.ps1 "update: your message"
```

## Licensing

Airway is licensed under the [MIT License](https://github.com/light-hat/airway/blob/master/LICENSE).

