using UnityEngine;
using System;
using System.Collections;

public class ClockMover : MonoBehaviour {

	private const float
	hoursToDegrees = 360f / 12f,
	minutesToDegrees = 360f / 60f,
	secondsToDegrees = 360f / 60f;

	public Transform hours, minutes, seconds;

	public GameObject[] Clock;

	public bool analog;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (analog)
		{
			//            float lerp = Mathf.PingPong(Time.time, duration) / duration;
			//transform.renderer.material.color = Color.Lerp(colorStart, colorEnd, lerp);
			//rend.material.color = colorStart;

			// gameObject.GetComponent<Renderer>().material.color = new Color(155, 48, 255);



			TimeSpan timespan = DateTime.Now.TimeOfDay;
			hours.localRotation = Quaternion.Euler(
				0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
			minutes.localRotation = Quaternion.Euler(
				0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
			seconds.localRotation = Quaternion.Euler(
				0f, 0f, (float)timespan.TotalSeconds * -secondsToDegrees);
		}
		else
		{
			DateTime time = DateTime.Now;
			hours.localRotation =
		Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
			minutes.localRotation =
				Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
			seconds.localRotation =
				Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);

		}

	}
}
