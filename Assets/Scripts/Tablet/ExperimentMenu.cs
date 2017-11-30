using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ExperimentMenu : TabletState
{
	public RectTransform content;
	public int lastExperiment;
	public Button prefab;
	public JournalController journalController;

    public int numeroDesafio;

	public GameObject[] stepTabs;

	public override TabletStates StateType {
		get {
			return TabletStates.ExperimentsMenu;
		}
	}

	 
	void Start ()
	{
        // RefreshScroll (0);
       // GoToExperiment();

    }

	void OnGUI(){
		Event e = Event.current;
		if (this.GetComponent<CanvasGroup> ().alpha == 1f) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				GetComponentInParent<TabletStateMachine>().resetState();
			}
		}
	}

	public void RefreshScroll(int numberOfSteps){
		////Always clean the previous items
		//int child = content.childCount;
		//for (int i = 0; i < child; i++) {
		//	Destroy(content.GetChild(i).gameObject);
		//}

		//stepTabs = new GameObject[numberOfSteps];
		////Generates new items
		//for (int i = 0; i < numberOfSteps; i++) {
		//	GameObject tempItem = Instantiate (prefab.gameObject) as GameObject;
		//	tempItem.name = "MenuButton"+i;
		//	string name = "";
		//	/*if(i == 0) {
		//		name = "Solução de NaCl 1 mol/litro";
		//	} else {
		//		tempItem.GetComponentInChildren<Text> ().text = tempItem.GetComponentInChildren<Text> ().text + (i+1); //The name is based on the prefab's text
		//	}*/
		//	//name = JournalSaver.GetExperimentName(i);
		//	name = "Desafio";
		//	tempItem.GetComponentInChildren<Text> ().text = name;
  //          numeroDesafio = int.Parse(tempItem.name.Substring(10));

  //         // tempItem.gameObject.GetComponent<Button> ().onClick.AddListener (() => GoToExperiment());
            
  //          tempItem.transform.SetParent (content.transform, false);

		//	stepTabs[i] = tempItem;
  //          //tempItem.SetActive(false);
  //          tempItem.gameObject.GetComponent<Button>().onClick.Invoke();
  //      }
	}
	/// <summary>
	/// Goes to "i" experiment.
	/// </summary>
	/// <param name="i">The index.</param>
	public void GoToExperiment(){
        //Gabi for it's working with VR
        Debug.Log("GoToExperiment :)");
        journalController.changeExperiment (0);
		GetComponentInParent<TabletStateMachine> ().goToState ((int)TabletStates.Experiments);
	}

	/// <summary>
	/// Activates the phase tab.
	/// </summary>
	/// <param name="numberOfStep">Number of actual step.</param>
	public void ActivatePhaseTab(int numberOfStep){
		//Debug.Log (stepTabs.
		stepTabs[numberOfStep].SetActive (true);
	}
}