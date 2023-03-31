using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Landpag2.Models.Authenticationconn
{
  [Table("SoftwareModulescatlist", Schema = "dbo")]
  public partial class SoftwareModulescatlist
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 sprModulecatid
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string sprModulecatDesc
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string sprModulecatDesc1
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string FuturecatDesc
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string FuturecatDesc1
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string photopath
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public decimal? InstallcatModule
    {
      get;
      set;
    }
  }
}
