using System;
using System.Collections.Generic;
using System.Linq;
using NavyPqs.Models;

namespace NavyPqs.Services
{
    public static class ConvertPqs
    {
        public static ConversionReport Convert(IPqs oldPqs, IPqs newPqs, IConversionModel model)
        {
            var report = new ConversionReport();
            report.Notes.Add(model.Notes);

            foreach (var lineItem in model.LineItemConversions)
            {
                var multiple = false;
                var oldSection = lineItem.OldLineItem;
                if (oldSection.ToLower().Contains('&'))
                {
                    multiple = true;
                }

                if (!multiple)
                {
                    var newSection = lineItem.NewLineItem;
                    var additions = lineItem.Additions;
                    var notes = lineItem.Notes;

                    string[] oldSectionSplit = oldSection.Split('.');
                    string[] newSectionSplit = newSection.Split('.');

                    string oldSectionNumber = oldSectionSplit[0];
                    string oldSignatureItem = oldSectionSplit[1];
                    string newSectionNumber = newSectionSplit[0];
                    string newSignatureItem = newSectionSplit[1];

                    var oldSectionIndex = oldPqs.Sections.FindIndex(a => a.Number == oldSectionNumber);
                    var newSectionIndex = newPqs.Sections.FindIndex(a => a.Number == newSectionNumber);

                    var oldSignedIndex = Array.IndexOf(oldPqs.Sections[oldSectionIndex].LineItem, oldSignatureItem);
                    var newSignedIndex = Array.IndexOf(newPqs.Sections[newSectionIndex].LineItem, newSignatureItem);

                    if (!oldPqs.Sections[oldSectionIndex].Signed[oldSignedIndex]) continue;
                    if (string.IsNullOrEmpty(additions))
                    {
                        newPqs.Sections[newSectionIndex].Signed[newSignedIndex] = true;
                        report.FullChecked.Add(new ConversionDetails(oldSection, newSection));
                    }
                    else
                    {
                        report.Partial.Add((new ConversionDetails(oldSection, newSection), additions));
                    }

                    if (!string.IsNullOrEmpty(notes))
                    {
                        report.Notes.Add(notes);
                    }
                }
                else
                {
                    var newSection = lineItem.NewLineItem;
                    string[] oldSections = oldSection.Split('&');
                    var additions = lineItem.Additions;
                    var notes = lineItem.Notes;
                    List<(string, string)> sectionSplits = new List<(string, string)>();
                    foreach (var section in oldSections)
                    {
                        string[] splits = section.Split('.');
                        sectionSplits.Add((splits[0].Trim(' '), splits[1].Trim(' ')));

                    }

                    string[] newSectionSplit = newSection.Split('.');

                    string newSectionNumber = newSectionSplit[0];
                    string newSignatureItem = newSectionSplit[1];
                    var newSectionIndex = newPqs.Sections.FindIndex(a => a.Number == newSectionNumber);
                    var newSignedIndex = Array.IndexOf(newPqs.Sections[newSectionIndex].LineItem, newSignatureItem);

                    List<(int, int)> oldIndexes = new List<(int, int)>();
                    for (int i = 0; i < sectionSplits.Count; i++)
                    {
                        var oldSectionIndex = oldPqs.Sections.FindIndex(a => a.Number == sectionSplits[i].Item1);
                        var oldSignedIndex = Array.IndexOf(oldPqs.Sections[oldSectionIndex].LineItem, sectionSplits[i].Item2);
                        oldIndexes.Add((oldSectionIndex, oldSignedIndex));
                    }

                    bool signed = oldIndexes.Aggregate(false,
                        (current, indexes) => current || oldPqs.Sections[indexes.Item1].Signed[indexes.Item2]);
                    if (!signed) continue;

                    bool allSigned = oldIndexes.Aggregate(true,
                        (current, indexes) => current && oldPqs.Sections[indexes.Item1].Signed[indexes.Item2]);
                    if (allSigned)
                    {
                        if (string.IsNullOrEmpty(additions))
                        {
                            newPqs.Sections[newSectionIndex].Signed[newSignedIndex] = true;
                            report.FullChecked.Add(new ConversionDetails(oldSection, newSection));
                        }
                        else
                        {
                            report.Partial.Add((new ConversionDetails(oldSection, newSection), additions));
                        }

                        if (!string.IsNullOrEmpty(notes))
                        {
                            report.Notes.Add(notes);
                        }
                    }
                    else
                    {
                        report.Partial.Add((new ConversionDetails(oldSection, newSection), additions));
                    }
                }

            }

            return report;
            }
        }
    }
