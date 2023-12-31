﻿using FAMS.V0.Shared.Domain.Entities;

namespace FAMS.V0.Shared.Events.SyllabusEvents;

public class EventSyllabusUpdated
{
    public Syllabus Syllabus { get; set; }

    public EventSyllabusUpdated(Syllabus syllabus)
    {
        Syllabus = syllabus;
    }
}