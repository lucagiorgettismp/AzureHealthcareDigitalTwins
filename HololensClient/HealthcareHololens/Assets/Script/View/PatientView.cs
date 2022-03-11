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
    private Patient Patient;

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

        Patient = null;
        TwinClient = null;
    }

    public async void UpdateView(Message message)
    {
        try
        {
            if (Patient == null)
            {
                Patient = await GetPatientTwin(message.device_id);
            }

            PatientName.text = Patient.Name;
            PatientSurname.text = Patient.Surname;
            PatientAge.text = Patient.Age.ToString();
            PatientGender.text = Patient.Gender;
            PatientHeight.text = Patient.Height.ToString();
            PatientWeight.text = Patient.Weight.ToString();
            PatientDescription.text = Patient.Description;
            PatientBodyMassIndex.text = Patient.BodyMassIndex.ToString();
            PatientFiscalCode.text = Patient.FiscalCode;
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

    private async Task<Patient> GetPatientTwin(string deviceId)
    {
        if (TwinClient == null)
        {
            TwinClient = TwinClientConnection();
        }

        Patient patient = await TwinOperationApi.GetPatient(TwinClient, deviceId);
        return patient;
    }
}
