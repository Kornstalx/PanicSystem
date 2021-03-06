﻿﻿using BattleTech;
// ReSharper disable All

 // thank you Frosty IRBTModUtils CustomDialog
 // https://github.com/IceRaptor/IRBTModUtils
namespace PanicSystem.Components.IRBTModUtilsCustomDialog {
    public class PanicSystemDialogMessage : MessageCenterMessage {

        // The message type to send dialog through
        public PanicSystemDialogMessage(AbstractActor dialogueSource, DialogueContent dialogueContent, float showDuration = 0f) : base() {
            this.dialogueSource = dialogueSource;
            this.dialogueContent = dialogueContent;
            this.showDuration = showDuration != 0f ? showDuration : dialogueContent.GetDialogueTime();
        }

        public override MessageCenterMessageType MessageType {
            get { return (MessageCenterMessageType)MessageTypes.OnCustomDialog; }
        }

        public AbstractActor DialogueSource {
            get { return dialogueSource; }
        }

        public DialogueContent DialogueContent {
            get { return dialogueContent; }
        }

        public float ShowDuration {
            get { return showDuration; }
        }

        public override void FromJSON(string json) { }

        public override string GenerateJSONTemplate() { return ""; }

        public override string ToJSON() { return ""; }

        private readonly AbstractActor dialogueSource;

        private readonly DialogueContent dialogueContent;

        private readonly float showDuration;

    }
}
