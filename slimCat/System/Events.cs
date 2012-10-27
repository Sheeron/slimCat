﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Models;

namespace slimCat
{
    /// <summary>
    /// This event is fired when the client should attempt to acquire an API ticket
    /// </summary>
    public class LoginEvent : CompositePresentationEvent<bool> {}

    /// <summary>
    /// This event is fired when the client has finished attempting to get the API ticket
    /// </summary>
    public class LoginCompleteEvent : CompositePresentationEvent<bool> {}

    /// <summary>
    /// This event is fired when the user has selected the character to login with
    /// </summary>
    public class CharacterSelectedLoginEvent : CompositePresentationEvent<string> { }

    /// <summary>
    /// This event is fired when the server sends us a command
    /// </summary>
    public class ChatCommandEvent : CompositePresentationEvent<IDictionary<string, object>> { }

    /// <summary>
    /// This event is fired when we are connected and the chat wrapper is displayed
    /// </summary>
    public class ChatOnDisplayEvent : CompositePresentationEvent<bool?> { }

    /// <summary>
    /// This even is fired when we are confirmed logged into the server.
    /// </summary>
    public class LoginAuthenticatedEvent : CompositePresentationEvent<bool?> { }

    /// <summary>
    /// This event is fired when we want to switch our active conversation tab
    /// </summary>
    public class RequestChangeTabEvent : CompositePresentationEvent<string> { }

    /// <summary>
    /// This event is fired when the user enters in a valid command
    /// </summary>
    public class UserCommandEvent : CompositePresentationEvent<IDictionary<string, object>> { }

    /// <summary>
    /// This event is fired when we have a new PM in a non-focused channel
    /// </summary>
    public class NewPMEvent : CompositePresentationEvent<IMessage> { }

    /// <summary>
    /// This event is fired when we have a new message in a non-focused channel
    /// </summary>
    public class NewMessageEvent : CompositePresentationEvent<IMessage> { }

    /// <summary>
    /// This event is fired when we need to alert the UI about an update, such as a user's status change
    /// </summary>
    public class NewUpdateEvent : CompositePresentationEvent<NotificationModel> { }

    /// <summary>
    ///  This event is used when the server has sent us an error or a module needs to display an error
    /// </summary>
    public class ErrorEvent : CompositePresentationEvent<string> { }
}
