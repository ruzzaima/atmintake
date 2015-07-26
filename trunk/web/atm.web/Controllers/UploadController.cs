using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SevenH.MMCSB.Atm.Domain;
using SevenH.MMCSB.Atm.Domain.Interface;

namespace SevenH.MMCSB.Atm.Web.Controllers
{
    public class UploadController : Controller
    {
        [HttpPost]
        public ActionResult Upload()
        {
            var uploadtype = Request.Form["uploadtype"];
            var applicantid = Request.Form["applicantid"];
            foreach (string fileu in Request.Files)
            {
                var hpf = Request.Files[fileu];
                if (hpf.ContentLength != 0 && hpf.FileName != null)
                {
                    var ext = Path.GetExtension(hpf.FileName).ToLower();

                    try
                    {
                        if (uploadtype == "LETTER")
                        {
                            if (hpf.ContentLength > 1000000)
                                return Json(new { Ok = false, message = "Muat naik tidak berjaya. Saiz fail melebihi saiz yang dibenarkan (500KB)", item = new object() }, JsonRequestBehavior.AllowGet);

                            if (applicantid != null)
                            {
                                var path = ConfigurationManager.AppSettings["SuppDocFolder"];
                                var appid = 0;
                                int.TryParse(applicantid, out appid);
                                var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(appid);
                                if (applicant != null)
                                {
                                    var guid = Guid.NewGuid().ToString();
                                    applicant.OriginalPelepasanDocument = hpf.FileName;
                                    applicant.PelepasanDocument = guid + ext;
                                    hpf.SaveAs(Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/SuppDoc"), (guid + ext)));
                                    applicant.Save();
                                    //hpf.SaveAs(savedFileName);
                                    return Json(new { OK = true, message = "Muatnaik Berjaya", item = JsonConvert.SerializeObject(new { PelepasanDocument = applicant.PelepasanDocument, OriginalPelepasanDocument = applicant.OriginalPelepasanDocument }) }, JsonRequestBehavior.AllowGet);

                                }
                            }
                        }

                        if (uploadtype == "PROFILE")
                        {
                            if (hpf.ContentLength > 500000)
                                return Json(new { Ok = false, message = "Muat naik tidak berjaya. Saiz fail melebihi saiz yang dibenarkan (300KB)", item = new object() }, JsonRequestBehavior.AllowGet);

                            if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".bmp")
                            {
                                var fileBytes = new byte[hpf.ContentLength];
                                var stream = hpf.InputStream.Read(fileBytes, 0, hpf.ContentLength);

                                if (applicantid != null)
                                {
                                    var appid = 0;
                                    int.TryParse(applicantid, out appid);
                                    var applicant = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetApplicant(appid);
                                    if (applicant != null)
                                    {
                                        var appphoto = new ApplicantPhoto()
                                        {
                                            Photo = fileBytes,
                                            PhotoExt = ext,
                                            ApplicantId = applicant.ApplicantId,
                                            CreatedBy = applicant.CreatedBy,
                                            CreatedDate = DateTime.Now
                                        };
                                        // check where there already exist the photo or not
                                        var existphoto = ObjectBuilder.GetObject<IApplicantPersistence>("ApplicantPersistence").GetPhoto(applicant.ApplicantId);
                                        if (null != existphoto && existphoto.Id != 0)
                                            appphoto.Id = existphoto.Id;

                                        appphoto.Save();
                                    }
                                }
                            }
                            else
                                return Json(new { OK = false, message = "Muatnaik tidak berjaya. Jenis fail tidak dibenarkan", item = new object() }, JsonRequestBehavior.AllowGet);

                            //hpf.SaveAs(savedFileName);
                            return Json(new { OK = true, message = "Muatnaik Berjaya", item = JsonConvert.SerializeObject("") }, JsonRequestBehavior.AllowGet);
                        }
                    }
                    catch (Exception exc)
                    {
                        throw exc;
                    }
                }
            }
            // Return JSON
            return Json(new { OK = false, message = "Not Succeed", item = new object() }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Download(string id, string fileName)
        {
            //var binStore = ObjectBuilder.GetObject<IBinaryStorePersistance>(SpringPersistanceKeys.BinaryStorePersistanceKey);
            //var doc = binStore.GetContent(id);

            //return File(doc.Content, GetContentType(doc.Extension), fileName);
            return null;
        }

        public ActionResult RemoveAttachement(string storeid)
        {
            if (string.IsNullOrWhiteSpace(storeid))
                return Json(new { OK = false, message = "Id Not Exists" });

            //ObjectBuilder.GetObject<IBinaryStorePersistance>(SpringPersistanceKeys.BinaryStorePersistanceKey).Remove(storeid);
            return Json(new { OK = true, message = "Document Successfully Removed." });
        }

        public static byte[] ReadFully(Stream input)
        {
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private static string GetContentType(string extension)
        {
            extension = extension.Replace(".", string.Empty).ToLower();
            switch (extension)
            {
                #region "html content type"

                case "gpx":
                    return "application/gpxx";
                case "evy":
                    return "application/envoy";
                case "fif":
                    return "application/fractals";
                case "spl":
                    return "application/futuresplash";
                case "hta":
                    return "application/hta";
                case "acx":
                    return "application/internet-property-stream";
                case "hqx":
                    return "application/mac-binhex40";
                case "doc":
                    return "application/msword";
                case "dot":
                    return "application/msword";
                case "*":
                    return "application/octet-stream";
                case "bin":
                    return "application/octet-stream";
                case "class":
                    return "application/octet-stream";
                case "dms":
                    return "application/octet-stream";
                case "exe":
                    return "application/octet-stream";
                case "lha":
                    return "application/octet-stream";
                case "lzh":
                    return "application/octet-stream";
                case "oda":
                    return "application/oda";
                case "axs":
                    return "application/olescript";
                case "pdf":
                    return "application/pdf";
                case "xps":
                    return "application/vnd.ms-xpsdocument";
                case "prf":
                    return "application/pics-rules";
                case "p10":
                    return "application/pkcs10";
                case "crl":
                    return "application/pkix-crl";
                case "ai":
                    return "application/postscript";
                case "eps":
                    return "application/postscript";
                case "ps":
                    return "application/postscript";
                case "rtf":
                    return "application/rtf";
                case "setpay":
                    return "application/set-payment-initiation";
                case "setreg":
                    return "application/set-registration-initiation";
                case "xla":
                    return "application/vnd.ms-excel";
                case "xlc":
                    return "application/vnd.ms-excel";
                case "xlm":
                    return "application/vnd.ms-excel";
                case "xls":
                    return "application/vnd.ms-excel";
                case "xlt":
                    return "application/vnd.ms-excel";
                case "xlw":
                    return "application/vnd.ms-excel";
                case "msg":
                    return "application/vnd.ms-outlook";
                case "sst":
                    return "application/vnd.ms-pkicertstore";
                case "cat":
                    return "application/vnd.ms-pkiseccat";
                case "stl":
                    return "application/vnd.ms-pkistl";
                case "pot":
                    return "application/vnd.ms-powerpoint";
                case "pps":
                    return "application/vnd.ms-powerpoint";
                case "ppt":
                    return "application/vnd.ms-powerpoint";
                case "mpp":
                    return "application/vnd.ms-project";
                case "wcm":
                    return "application/vnd.ms-works";
                case "wdb":
                    return "application/vnd.ms-works";
                case "wks":
                    return "application/vnd.ms-works";
                case "wps":
                    return "application/vnd.ms-works";
                case "hlp":
                    return "application/winhlp";
                case "bcpio":
                    return "application/x-bcpio";
                case "cdf":
                    return "application/x-cdf";
                case "z":
                    return "application/x-compress";
                case "tgz":
                    return "application/x-compressed";
                case "cpio":
                    return "application/x-cpio";
                case "csh":
                    return "application/x-csh";
                case "dcr":
                    return "application/x-director";
                case "dir":
                    return "application/x-director";
                case "dxr":
                    return "application/x-director";
                case "dvi":
                    return "application/x-dvi";
                case "gtar":
                    return "application/x-gtar";
                case "gz":
                    return "application/x-gzip";
                case "hdf":
                    return "application/x-hdf";
                case "ins":
                    return "application/x-internet-signup";
                case "isp":
                    return "application/x-internet-signup";
                case "iii":
                    return "application/x-iphone";
                case "js":
                    return "application/x-javascript";
                case "latex":
                    return "application/x-latex";
                case "mdb":
                    return "application/x-msaccess";
                case "crd":
                    return "application/x-mscardfile";
                case "clp":
                    return "application/x-msclip";
                case "dll":
                    return "application/x-msdownload";
                case "m13":
                    return "application/x-msmediaview";
                case "m14":
                    return "application/x-msmediaview";
                case "mvb":
                    return "application/x-msmediaview";
                case "wmf":
                    return "application/x-msmetafile";
                case "mny":
                    return "application/x-msmoney";
                case "pub":
                    return "application/x-mspublisher";
                case "scd":
                    return "application/x-msschedule";
                case "trm":
                    return "application/x-msterminal";
                case "wri":
                    return "application/x-mswrite";
                case "nc":
                    return "application/x-netcdf";
                case "pma":
                    return "application/x-perfmon";
                case "pmc":
                    return "application/x-perfmon";
                case "pml":
                    return "application/x-perfmon";
                case "pmr":
                    return "application/x-perfmon";
                case "pmw":
                    return "application/x-perfmon";
                case "p12":
                    return "application/x-pkcs12";
                case "pfx":
                    return "application/x-pkcs12";
                case "p7b":
                    return "application/x-pkcs7-certificates";
                case "spc":
                    return "application/x-pkcs7-certificates";
                case "p7r":
                    return "application/x-pkcs7-certreqresp";
                case "p7c":
                    return "application/x-pkcs7-mime";
                case "p7m":
                    return "application/x-pkcs7-mime";
                case "p7s":
                    return "application/x-pkcs7-signature";
                case "sh":
                    return "application/x-sh";
                case "shar":
                    return "application/x-shar";
                case "swf":
                    return "application/x-shockwave-flash";
                case "sit":
                    return "application/x-stuffit";
                case "sv4cpio":
                    return "application/x-sv4cpio";
                case "sv4crc":
                    return "application/x-sv4crc";
                case "tar":
                    return "application/x-tar";
                case "tcl":
                    return "application/x-tcl";
                case "tex":
                    return "application/x-tex";
                case "texi":
                    return "application/x-texinfo";
                case "texinfo":
                    return "application/x-texinfo";
                case "roff":
                    return "application/x-troff";
                case "t":
                    return "application/x-troff";
                case "tr":
                    return "application/x-troff";
                case "man":
                    return "application/x-troff-man";
                case "me":
                    return "application/x-troff-me";
                case "ms":
                    return "application/x-troff-ms";
                case "ustar":
                    return "application/x-ustar";
                case "src":
                    return "application/x-wais-source";
                case "cer":
                    return "application/x-x509-ca-cert";
                case "crt":
                    return "application/x-x509-ca-cert";
                case "der":
                    return "application/x-x509-ca-cert";
                case "pko":
                    return "application/ynd.ms-pkipko";
                case "zip":
                    return "application/zip";
                case "au":
                    return "audio/basic";
                case "snd":
                    return "audio/basic";
                case "mid":
                    return "audio/mid";
                case "rmi":
                    return "audio/mid";
                case "mp3":
                    return "audio/mpeg";
                case "aif":
                    return "audio/x-aiff";
                case "aifc":
                    return "audio/x-aiff";
                case "aiff":
                    return "audio/x-aiff";
                case "m3u":
                    return "audio/x-mpegurl";
                case "ra":
                    return "audio/x-pn-realaudio";
                case "ram":
                    return "audio/x-pn-realaudio";
                case "wav":
                    return "audio/x-wav";
                case "bmp":
                    return "image/bmp";
                case "cod":
                    return "image/cis-cod";
                case "gif":
                    return "image/gif";
                case "ief":
                    return "image/ief";
                case "jpe":
                    return "image/jpeg";
                case "jpeg":
                    return "image/jpeg";
                case "jpg":
                    return "image/jpeg";
                case "jfif":
                    return "image/pipeg";
                case "svg":
                    return "image/svg+xml";
                case "tif":
                    return "image/tiff";
                case "tiff":
                    return "image/tiff";
                case "ras":
                    return "image/x-cmu-raster";
                case "cmx":
                    return "image/x-cmx";
                case "ico":
                    return "image/x-icon";
                case "pnm":
                    return "image/x-portable-anymap";
                case "pbm":
                    return "image/x-portable-bitmap";
                case "pgm":
                    return "image/x-portable-graymap";
                case "ppm":
                    return "image/x-portable-pixmap";
                case "rgb":
                    return "image/x-rgb";
                case "xbm":
                    return "image/x-xbitmap";
                case "xpm":
                    return "image/x-xpixmap";
                case "xwd":
                    return "image/x-xwindowdump";
                case "mht":
                    return "message/rfc822";
                case "mhtml":
                    return "message/rfc822";
                case "nws":
                    return "message/rfc822";
                case "css":
                    return "text/css";
                case "323":
                    return "text/h323";
                case "htm":
                    return "text/html";
                case "html":
                    return "text/html";
                case "stm":
                    return "text/html";
                case "uls":
                    return "text/iuls";
                case "bas":
                    return "text/plain";
                case "c":
                    return "text/plain";
                case "h":
                    return "text/plain";
                case "txt":
                    return "text/plain";
                case "rtx":
                    return "text/richtext";
                case "sct":
                    return "text/scriptlet";
                case "tsv":
                    return "text/tab-separated-values";
                case "htt":
                    return "text/webviewhtml";
                case "htc":
                    return "text/x-component";
                case "etx":
                    return "text/x-setext";
                case "vcf":
                    return "text/x-vcard";
                case "mp2":
                    return "video/mpeg";
                case "mpa":
                    return "video/mpeg";
                case "mpe":
                    return "video/mpeg";
                case "mpeg":
                    return "video/mpeg";
                case "mpg":
                    return "video/mpeg";
                case "mpv2":
                    return "video/mpeg";
                case "mov":
                    return "video/quicktime";
                case "qt":
                    return "video/quicktime";
                case "lsf":
                    return "video/x-la-asf";
                case "lsx":
                    return "video/x-la-asf";
                case "asf":
                    return "video/x-ms-asf";
                case "asr":
                    return "video/x-ms-asf";
                case "asx":
                    return "video/x-ms-asf";
                case "avi":
                    return "video/x-msvideo";
                case "movie":
                    return "video/x-sgi-movie";
                case "flr":
                    return "x-world/x-vrml";
                case "vrml":
                    return "x-world/x-vrml";
                case "wrl":
                    return "x-world/x-vrml";
                case "wrz":
                    return "x-world/x-vrml";
                case "xaf":
                    return "x-world/x-vrml";
                case "xof":
                    return "x-world/x-vrml";

                // new ms office 2007
                case "docm":
                    return "application/vnd.ms-word.document.macroEnabled.12";
                case "docx":
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                case "dotm":
                    return "application/vnd.ms-word.template.macroEnabled.12";
                case "dotx":
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.template";
                case "potm":
                    return "application/vnd.ms-powerpoint.template.macroEnabled.12";
                case "potx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.template";
                case "ppam":
                    return "application/vnd.ms-powerpoint.addin.macroEnabled.12";
                case "ppsm":
                    return "application/vnd.ms-powerpoint.slideshow.macroEnabled.12";
                case "ppsx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.slideshow";
                case "pptm":
                    return "application/vnd.ms-powerpoint.presentation.macroEnabled.12";
                case "pptx":
                    return "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                case "xlam":
                    return "application/vnd.ms-excel.addin.macroEnabled.12";
                case "xlsb":
                    return "application/vnd.ms-excel.sheet.binary.macroEnabled.12";
                case "xlsm":
                    return "application/vnd.ms-excel.sheet.macroEnabled.12";
                case "xlsx":
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                case "xltm":
                    return "application/vnd.ms-excel.template.macroEnabled.12";
                case "xltx":
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.template";

                #endregion
            }

            return string.Empty;
        }
    }
}