using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameClock : MonoBehaviour {

	private const int TIMESCALE = 300;

	private Text clockText;
	public static Text dayText;
	private Text yearText;
	private Text seasonText;

	private double minute, hour, second, day, year, month;

	void Start(){
	
		year = 1;
		day = 1;
		year = 1;

		clockText = GameObject.Find ("Clock").GetComponent<Text>();
		dayText = GameObject.Find ("Day").GetComponent<Text>();
		seasonText = GameObject.Find ("Season").GetComponent<Text> ();
		yearText = GameObject.Find ("Year").GetComponent<Text> ();
	}

	void Update(){
		calculateTime ();
	}

	void textCallFunction(){
		clockText.text = hour + ":" + minute;
		dayText.text = "Day:" + day;
		yearText.text = "Year: " + year;
	}

	void calculateSeason()
	{
		if (month == 12 || month == 1 || month == 2) 
			seasonText.text = "Winter";
		else if (month == 3 || month == 4 || month == 5) 
			seasonText.text = "Spring";
		else if (month == 6 || month == 7 || month == 8) 
			seasonText.text = "Summer";
		else if(month == 9 || month == 10|| month == 11)
			seasonText.text = "Fall";
		

		Debug.Log (month + " " + seasonText);

	}
	void calculateMonth()
	{
		if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
			if (day >= 32) {
				month++;
				day = 1;
				textCallFunction ();
				calculateSeason ();
		
			}
		}
		if (month == 2) {
			if (day >= 29) {
				month++;
				day = 1;
				textCallFunction ();
				calculateSeason ();
			}
		}

		if (month == 4 || month == 6 || month == 9 || month == 11) {
			if (day >= 31) {
				month++;
				day = 1;
				textCallFunction();
				calculateSeason();
			}
		}
	}

	void calculateTime()
	{
		second += Time.fixedDeltaTime * TIMESCALE;
		if (second >= 60) {
			minute++;
			second = 0;
			textCallFunction ();
		} else if (minute >= 60) 
		{
			hour++;
			minute = 0;
			textCallFunction();
		}else if (hour >= 24)
		{
			day++;
			hour = 0;
			textCallFunction ();
		}else if(day >= 28)
		{
			calculateMonth ();
		}else if(month >= 13)
		{
			month = 1;
			year++;
			textCallFunction ();
			calculateSeason ();
		}
	}
}

