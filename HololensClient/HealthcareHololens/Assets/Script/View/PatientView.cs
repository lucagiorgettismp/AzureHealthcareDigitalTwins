using System;
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
    }

    public void UpdateView(Message message)
    {
        try
        {
            PatientName.text = message.patient_name;
            PatientSurname.text = message.patient_surname;
            PatientAge.text = message.patient_age.ToString();
            PatientGender.text = message.patient_gender;
            PatientHeight.text = message.patient_height.ToString();
            PatientWeight.text = message.patient_weight.ToString();
            PatientDescription.text = message.patient_description;
            PatientBodyMassIndex.text = message.patient_body_mass_index.ToString();
            PatientFiscalCode.text = message.patient_fiscal_code;
        }
        catch (Exception e)
        {
            Debug.LogError("Error: " + e.Message);
        }
    }

}
