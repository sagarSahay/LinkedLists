using Common;
using FluentAssertions;
using Xunit;

namespace ReverseLinkedList.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void ReverseList_WhenGivenInput_ReversesList()
        {
            //1->2->3->4->5->NULL
            // Arrange
            var input = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };

            var sut = new Solution();
            
            // Act
            var res = sut.ReverseList(input);
            
            // Assert
            
            var expected = new ListNode(5)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                        }
                    }
                }
            };
            res.Should().BeEquivalentTo(expected);
        }
    }
}