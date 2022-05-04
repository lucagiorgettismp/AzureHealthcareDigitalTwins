# AzureHealthcareDigitalTwins
Project for Pervasive Computing and Laboratorio di Sistemi Software Courses.

[![DeepSource](https://img.shields.io/website-up-down-green-red/http/monip.org.svg)](https://lucagiorgettismp.github.io/AzureHealthcareDigitalTwins/)

[![Release](https://img.shields.io/github/v/release/lucagiorgettismp/AzureHealthcareDigitalTwins?label=Release)](https://github.com/lucagiorgettismp/AzureHealthcareDigitalTwins/releases)
[![GitHub](https://img.shields.io/github/license/lucagiorgettismp/AzureHealthcareDigitalTwins)](/LICENSE)

[![Main CI](https://github.com/lucagiorgettismp/AzureHealthcareDigitalTwins/actions/workflows/main-ci.yml/badge.svg)](https://github.com/lucagiorgettismp/AzureHealthcareDigitalTwins/actions/workflows/main-ci.yml)
[![CodeFactor](https://www.codefactor.io/repository/github/lucagiorgettismp/azurehealthcaredigitaltwins/badge/main)](https://www.codefactor.io/repository/github/lucagiorgettismp/azurehealthcaredigitaltwins/overview/main)
[![DeepSource](https://deepsource.io/gh/lucagiorgettismp/AzureHealthcareDigitalTwins.svg/?label=active+issues&token=TkpQppm2NjIFNsKDCeZRPHlD)](https://deepsource.io/gh/lucagiorgettismp/AzureHealthcareDigitalTwins/?ref=repository-badge)
[![DeepSource](https://deepsource.io/gh/lucagiorgettismp/AzureHealthcareDigitalTwins.svg/?label=resolved+issues&token=TkpQppm2NjIFNsKDCeZRPHlD)](https://deepsource.io/gh/lucagiorgettismp/AzureHealthcareDigitalTwins/?ref=repository-badge)

## What does our application do
AzureHealthcareDigitalTwins purpose is to craete and feed a Vital Signs Monitor Digital Twin, with vital parameters and alarms and display it in Mixed Reality, by making use of Hololens 2 device.

The project is composed by 3 different applications:
- Backend Client: allows to create patient report and it's digital twin;
- Simulator: simulates the Vital Signs Monitor phisical asset;
- Hololens App: displays the mixed reality monitor and allow user to interact with it, by switching and saving visualitazion modes;

Digital Twins are deployed into Azure Platform.

## Requirements for deploying
- Visual Studio 2019
- Unity 2020.3.4f
- Azure subscription
