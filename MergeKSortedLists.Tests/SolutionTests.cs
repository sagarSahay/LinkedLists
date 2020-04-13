using Common;
using FluentAssertions;
using Xunit;

namespace MergeKSortedLists.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void MergeKLists_GivenSortedLinkedLists_MergesThem()
        {
            // [
            // 1->4->5,
            // 1->3->4,
            // 2->6
            //     ]
            // Arrange 
            var ls1 = new ListNode(1)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(5)
                }
            };
            
            var ls2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                }
            };
            
            var ls3 = new ListNode(2)
            {
                next = new ListNode(6)
            };
            var sut = new Solution();
            
            // Act
            var res = sut.MergeKLists(new[] {ls1, ls2, ls3});
            
            // Assert
            //1->1->2->3->4->4->5->6
            
            var expected = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(4)
                                {
                                    next = new ListNode(5)
                                    {
                                        next = new ListNode(6)
                                    }
                                }
                            }
                        }
                    }
                }
            };
            
            res.Should().BeEquivalentTo(expected);
        }
    }
}