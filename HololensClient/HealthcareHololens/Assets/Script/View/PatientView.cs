using Azure.DigitalTwins.Core;
using AzureDigitalTwins;
using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class PatientView : BaseApplicationPanel
{
    private TextMeshPro PatientName;
    private TextMeshPro PatientSurname;
    private TextMeshPro PatientAge;
    private TextMeshPro PatientGender;
    private TextMeshPro PatientHeight;
    private TextMeshPro PatientWeight;
    private TextMeshPro PatientDescription;
    private TextMeshPro PatientBodyMassIndex;
    private TextMeshPro PatientFiscalCode;

    private DigitalTwinsClient TwinClient;

    void Awake()
    {
        PatientName = GameObject.Find("PatientName").GetComponent<TextMeshPro>();
        PatientSurname = GameObject.Find("PatientSurname").GetComponent<TextMeshPro>();
        PatientAge = GameObject.Find("PatientAge").GetComponent<TextMeshPro>();
        PatientGender = GameObject.Find("PatientGender").GetComponent<TextMeshPro>();
        PatientHeight = GameObject.Find("PatientHeight").GetComponent<TextMeshPro>();
        PatientWeight = GameObject.Find("PatientWeight").GetComponent<TextMeshPro>();
        PatientDescription = GameObject.Find("PatientDescription").GetComponent<TextMeshPro>();
        PatientBodyMassIndex = GameObject.Find("PatientBodyMassIndex").GetComponent<TextMeshPro>();
        PatientFiscalCode = GameObject.Find("PatientFiscalCode").GetComponent<TextMeshPro>();

        TwinClient = null;
    }

    public void SetPatient(Patient patient)
    {
        try
        {
            if (patient != null)
            {
                PatientName.text = patient.Name;
                PatientSurname.text = patient.Surname;
                PatientAge.text = patient.Age.ToString();
                PatientGender.text = patient.Gender;
                PatientHeight.text = patient.Height.ToString();
                PatientWeight.text = patient.Weight.ToString();
                PatientDescription.text = patient.Description;
                PatientBodyMassIndex.text = patient.BodyMassIndex.ToString();
                PatientFiscalCode.text = patient.FiscalCode;
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }

    private DigitalTwinsClient TwinClientConnection()
    {
        return TwinOperationApi.GetClient();
    }

    public async Task Initialize(string deviceId)
    {
        if (TwinClient == null)
        {
            TwinClient = TwinClientConnection();
        }

        Patient patient = await TwinOperationApi.GetPatient(TwinClient, deviceId);
        SetPatient(patient);
    }
}
