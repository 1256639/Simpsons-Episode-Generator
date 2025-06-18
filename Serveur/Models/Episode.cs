using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SimpsonsEpisodeGenerator.Models;

public partial class Episode
{
    [Key]
    public int Id { get; set; }

    public int SeasonNumber { get; set; }

    public int EpisodeNumber { get; set; }

    [StringLength(255)]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }
}
