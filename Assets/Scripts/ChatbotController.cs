using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatbotController : MonoBehaviour
{
    public TMP_InputField playerInputField; // Reference to player input field
    public TextMeshProUGUI chatbotResponseText; // Reference to chat output text

    void Start()
    {
        // Initial welcome message
        DisplayMessage("Welcome to Fly Ninja! Ask me about the rules or gameplay.");
    }

    public void OnSendButton()
    {
        string playerMessage = playerInputField.text.ToLower();
        playerInputField.text = ""; 

        string response = GetResponse(playerMessage);

        DisplayMessage(response);
    }

    string GetResponse(string message)
    {
        if (message.Contains("rules"))
            return "Rules: Swat the flies to gain points, but don't swat the dog!";
        else if (message.Contains("flies"))
            return "Flies give you 1 point each. Swat multiple flies at once for bonuses!";
        else if (message.Contains("dog"))
            return "The dog is a hazard. If you swat it, you go back to the MainMenu!";
        else if (message.Contains("bonus"))
            return "Swatting multiple flies at once gives you a bonus of +10 points!";
        else
            return "I didn’t understand that. Try asking about 'rules', 'flies', 'dog', or 'bonus'.";
    }

    void DisplayMessage(string message)
    {
        // Append the chatbot's message to the chat output
        chatbotResponseText.text += message + "\n";
    }
}
