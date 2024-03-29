﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Shared.Infrastructure;

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string message);
}
