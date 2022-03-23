using Assets.Script.View;
using System;
using TMPro;
using UnityEngine;

public class PatientPanel : BaseApplicationPanel
{
    private TextMeshPro _patientName;
    private TextMeshPro _patientSurname;
    private TextMeshPro _patientAge;
    private TextMeshPro _patientGender;
    private TextMeshPro _patientHeight;
    private TextMeshPro _patientWeight;
    private TextMeshPro _patientDescription;
    private TextMeshPro _patientBodyMassIndex;
    private TextMeshPro _patientFiscalCode;
    private TextMeshPro _patientLoading;

    public void Awake()
    {
        _patientName = GameObject.Find("PatientName").GetComponent<TextMeshPro>();
        _patientSurname = GameObject.Find("PatientSurname").GetComponent<TextMeshPro>();
        _patientAge = GameObject.Find("PatientAge").GetComponent<TextMeshPro>();
        _patientGender = GameObject.Find("PatientGender").GetComponent<TextMeshPro>();
        _patientHeight = GameObject.Find("PatientHeight").GetComponent<TextMeshPro>();
        _patientWeight = GameObject.Find("PatientWeight").GetComponent<TextMeshPro>();
        _patientDescription = GameObject.Find("PatientDescription").GetComponent<TextMeshPro>();
        _patientBodyMassIndex = GameObject.Find("PatientBodyMassIndex").GetComponent<TextMeshPro>();
        _patientFiscalCode = GameObject.Find("PatientFiscalCode").GetComponent<TextMeshPro>();
    }

    public void SetPatient(Patient patient)
    {
        try
        {
            if (patient != null)
            {
                _patientName.text = "Name: " + patient.Name;
                _patientSurname.text = "Surname: "+ patient.Surname;
                _patientAge.text = "Age: " + patient.Age.ToString();
                _patientGender.text = "Gender: " + patient.Gender;
                _patientHeight.text = "Height: " + patient.Height.ToString() + " m";
                _patientWeight.text = "Weight: " + patient.Weight.ToString() + " Kg";
                _patientDescription.text = "Description: " + patient.Description;
                _patientBodyMassIndex.text = "Body Mass Index: " + patient.BodyMassIndex.ToString();
                _patientFiscalCode.text = "Fiscal Code: " + patient.FiscalCode;
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }
}
