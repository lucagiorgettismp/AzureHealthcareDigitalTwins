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
    private TextMeshPro PatientLoading;

    public void Awake()
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
        PatientLoading = GameObject.Find("PatientLoading").GetComponent<TextMeshPro>();
    }

    public void SetPatient(Patient patient)
    {
        try
        {
            if (patient != null)
            {
                this.PatientLoading.gameObject.SetActive(false);

                PatientName.text = "Name: " + patient.Name;
                PatientSurname.text = "Surname: "+ patient.Surname;
                PatientAge.text = "Age: " + patient.Age.ToString();
                PatientGender.text = "Gender: " + patient.Gender;
                PatientHeight.text = "Height: " + patient.Height.ToString() + " m";
                PatientWeight.text = "Weight: " + patient.Weight.ToString() + " Kg";
                PatientDescription.text = "Description: " + patient.Description;
                PatientBodyMassIndex.text = "Body Mass Index: " + patient.BodyMassIndex.ToString() + " Kg/m2";
                PatientFiscalCode.text = "Fiscal Code: " + patient.FiscalCode;
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }

    public async Task Initialize()
    {
        this.PatientLoading.text = "Loading....";

        var patient = await App.Controller.GetPatientAsync();

        SetPatient(patient);
    }
}
